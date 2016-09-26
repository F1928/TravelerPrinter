using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ReceivingTravelerBarcodePrinter
{
    public static class DataParser
    {
        public static string CreateNo()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(9999);
            string now= DateTime.Now.ToString("yyyyMMddHHmmssffff");
            return string.Format("{0}{1:0000}", now, rndNum);
        }

        public static void NullValueAsEmpty(this DataTable tb)
        {
            
            foreach (DataRow row in tb.Rows)
            {
                foreach (DataColumn col in tb.Columns)
                {
                    if (row.IsNull(col))
                    {
                        if (col.DataType == typeof(string))
                            row.SetField<string>(col, string.Empty);
                    }                       
                }
            }
        }

        public static ASN ToASNDataSet(this DataTable tb)
        {
            ASN asn = new ASN();

            for (int i = tb.Rows.Count - 1; i >= 0; i--)
            {
                if (tb.Rows[i].IsNull(Col.colPO) ||
                    tb.Rows[i].IsNull(Col.colSupplier) ||
                    tb.Rows[i].IsNull(Col.colPN) ||
                    tb.Rows[i].IsNull(Col.colQTY) ||
                    tb.Rows[i].IsNull(Col.colDN))
                {
                    tb.Rows[i].Delete();
                    continue;
                }
                if (string.IsNullOrEmpty(tb.Rows[i][Col.colPO].ToString()) ||
                    string.IsNullOrEmpty(tb.Rows[i][Col.colSupplier].ToString()) ||
                    string.IsNullOrEmpty(tb.Rows[i][Col.colPN].ToString()) ||
                    string.IsNullOrEmpty(tb.Rows[i][Col.colQTY].ToString()) ||
                    string.IsNullOrEmpty(tb.Rows[i][Col.colDN].ToString()))
                {
                    tb.Rows[i].Delete();
                }
            }
            tb.AcceptChanges();

            string NO = CreateNo();           

            var qMst = (from x in tb.AsEnumerable()
                        select new
                        {
                            SUPPLIER = x.Field<string>(Col.colSupplier),
                            PALLET_NO = x.Field<string>(Col.colPalletNO),
                            DN = x.Field<string>(Col.colDN)
                        }).Distinct();

            var orderedMst = from x in qMst
                             orderby x.SUPPLIER, x.PALLET_NO, x.DN
                             select x;

            int mstID = 0;
            int dtlID = 0;
            int qtyID = 0;
            string theDate = string.Empty;
            foreach (var x in orderedMst)
            {
                mstID += 1;
                ASN.ASN_MSTRow mstRow = asn.ASN_MST.NewASN_MSTRow();
                
                if (tb.Columns[Col.colDate].DataType == typeof(DateTime))
                {
                    theDate = tb.AsEnumerable()
                                .Where(f=>f.Field<string>(Col.colDN)==x.DN)
                                .First()
                                .Field<DateTime>(Col.colDate)
                                .ToString("yyyy-MM-dd");
                }
                else
                {
                    theDate = tb.AsEnumerable()
                                .Where(f => f.Field<string>(Col.colDN) == x.DN)
                                .First()
                                .Field<string>(Col.colDate);
                    theDate = DateTime.Parse(theDate).ToString("yyyy-MM-dd");
                }

                mstRow.ID = mstID;
                mstRow.DN = x.DN;
                mstRow.NO = NO;
                mstRow.PALLET_NO = x.PALLET_NO;
                mstRow.SUPPLIER = x.SUPPLIER;
                mstRow.DATE = theDate;
                mstRow.TOTAL_QTY = 0;

                //DN条码的格式为<HT><CR><HT>DN<HT><HT><HT><HT><CR>1<DC3>
                //其中<HT>是TAB，<CR> 是Enter（回车键），1为数字1，<DC3>为Backspace<退格键>
                mstRow.DN_BCD = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}1{9}",
                                               (char)Keys.Tab,
                                               (char)Keys.Enter,
                                               (char)Keys.Tab,
                                               x.DN,
                                               (char)Keys.Tab,
                                               (char)Keys.Tab,
                                               (char)Keys.Tab,
                                               (char)Keys.Tab,
                                               (char)Keys.Enter,
                                               (char)Keys.Back);
                asn.ASN_MST.AddASN_MSTRow(mstRow);

                var qDtl = (from d in tb.AsEnumerable()
                            where d[Col.colDN].ToString() == x.DN
                               && d[Col.colPalletNO].ToString() == x.PALLET_NO
                               && d[Col.colSupplier].ToString() == x.SUPPLIER
                            select new
                            {
                                PO = d[Col.colPO].ToString(),
                                WO = d[Col.colWO].ToString()
                            }).Distinct();

                var orderedDtl = from d in qDtl
                                 orderby d.PO, d.WO
                                 select d;

                foreach (var d in orderedDtl)
                {
                    dtlID += 1;
                    ASN.ASN_DTLRow dtlRow = asn.ASN_DTL.NewASN_DTLRow();
                    dtlRow.ID = dtlID;
                    dtlRow.PO = d.PO;
                    dtlRow.WO = d.WO;
                    //PO条码的格式: PO<HT><HT>
                    dtlRow.PO_BCD = string.Format("{0}{1}{2}", d.PO, (char)Keys.Tab, (char)Keys.Tab);
                    //WO条码的格式: WO<HT>
                    dtlRow.WO_BCD = string.Format("{0}{1}", d.WO, (char)Keys.Tab);
                    dtlRow.MST_ID = mstID;
                    dtlRow.KEY = string.Format("{0}-{1}-{2}", mstRow.DN, d.PO, d.WO);
                    asn.ASN_DTL.AddASN_DTLRow(dtlRow);

                    var qQty = from q in tb.AsEnumerable()
                               where q[Col.colDN].ToString() == x.DN
                              && q[Col.colPalletNO].ToString() == x.PALLET_NO
                              && q[Col.colSupplier].ToString() == x.SUPPLIER
                              && q[Col.colPO].ToString() == d.PO
                              && q[Col.colWO].ToString() == d.WO
                               orderby q.Field<string>(Col.colPN)
                               select new
                               {
                                   PN = q[Col.colPN].ToString(),
                                   REV = q[Col.colREV].ToString(),
                                   QTY = decimal.Parse(q[Col.colQTY].ToString())
                               };


                    foreach (var q in qQty)
                    {
                        qtyID += 1;
                        ASN.ASN_PN_QTYRow qtyRow = asn.ASN_PN_QTY.NewASN_PN_QTYRow();
                        qtyRow.ID = qtyID;
                        qtyRow.PN = q.PN;
                        qtyRow.REV = q.REV;
                        qtyRow.QTY = q.QTY;
                        // PN条码的格式： PN<HT><HT><HT>
                        qtyRow.PN_BCD = string.Format("{0}{1}{1}{1}", q.PN, (char)Keys.Tab);
                        // Quantity条码的格式: <HT>QTY<HT><CR>
                        qtyRow.QTY_BCD = string.Format("{0}{1}{2}{3}", (char)Keys.Tab, q.QTY, (char)Keys.Tab, (char)Keys.Enter);
                        qtyRow.DTL_ID = dtlID;
                        mstRow.TOTAL_QTY += q.QTY;
                        asn.ASN_PN_QTY.AddASN_PN_QTYRow(qtyRow);
                    }

                }
            }

            return asn;
        }

        public static Aspose.Cells.GridDesktop.Style CreateNullStyle(this Aspose.Cells.GridDesktop.GridDesktop grid)
        {
            Aspose.Cells.GridDesktop.Style nullStyle = new Aspose.Cells.GridDesktop.Style(grid);
            nullStyle.Name = "NullStyle";
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Left, Aspose.Cells.GridDesktop.BorderLineType.Thick);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Top, Aspose.Cells.GridDesktop.BorderLineType.Thick);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Right, Aspose.Cells.GridDesktop.BorderLineType.Thick);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Bottom, Aspose.Cells.GridDesktop.BorderLineType.Thick);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Left, Color.Red);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Top, Color.Red);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Right, Color.Red);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Bottom, Color.Red);
            //nullStyle.Color = Color.Red;
            return nullStyle;
        }

        public static Aspose.Cells.GridDesktop.Style CreateNormalStyle(this Aspose.Cells.GridDesktop.GridDesktop grid)
        {
            Aspose.Cells.GridDesktop.Style nullStyle = new Aspose.Cells.GridDesktop.Style(grid);
            nullStyle.Name = "NormalStyle";
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Left, Aspose.Cells.GridDesktop.BorderLineType.Thin);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Top, Aspose.Cells.GridDesktop.BorderLineType.Thin);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Right, Aspose.Cells.GridDesktop.BorderLineType.Thin);
            nullStyle.SetBorderLine(Aspose.Cells.GridDesktop.BorderType.Bottom, Aspose.Cells.GridDesktop.BorderLineType.Thin);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Left, Color.Black);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Top, Color.Black);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Right, Color.Black);
            nullStyle.SetBorderColor(Aspose.Cells.GridDesktop.BorderType.Bottom, Color.Black);
            //nullStyle.Color = Color.Red;
            return nullStyle;
        }

        public static void IntelligentSkip(this Aspose.Cells.GridDesktop.Worksheet sheet)
        {
            for (int row = sheet.RowsCount-1; row>=0 ; row--)
            {
                int nullCount = 0;
                for (int col = 0; col < sheet.ColumnsCount; col++)
                {
                    Aspose.Cells.GridDesktop.GridCell cell = sheet.Cells[row, col];

                    object objValue = cell.Value;

                    if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                    {
                        nullCount += 1;
                    }

                    if (nullCount > 6)
                    {
                        sheet.RemoveRow(row);
                    }
                }
            }
        }

        public static string CheckData(this Aspose.Cells.GridDesktop.Worksheet sheet)
        {
            StringBuilder sb = new StringBuilder("");

            Aspose.Cells.GridDesktop.Style nullStyle =sheet.GridDesktop.CreateNullStyle();

            for (int row = 1; row < sheet.RowsCount; row++)
            {
                for (int col = 0; col < sheet.ColumnsCount; col++)
                {
                    Aspose.Cells.GridDesktop.GridCell cell = sheet.Cells[row, col];
                    if (Col.NotNullColumns.Count(f => f == col) > 0)
                    {
                        object objValue = cell.Value;

                        if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                        {
                            sb.AppendFormat("{0},", Aspose.Cells.GridDesktop.Worksheet.CellIndexToName(row, col));
                            cell.SetStyle(nullStyle);
                        }
                    }
                }
            }
            if (sb.Length < 1)
            {
                return string.Empty;
            }
            else
            {
                string msg = string.Format("下列用红色边框标记的栏位内容不能为空:\r\n{0}", sb.ToString().TrimEnd(','));
                return msg;
            }
        }

    }
}
