using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceivingTravelerBarcodePrinter
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

         private bool CheckDataPassed()
        {
            string msg = this.gridDesktop.Worksheets[0].CheckData();
            if (!string.IsNullOrEmpty(msg))
            {
                Messenger.ShowException(this, msg);
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            #region Example
            
            //DataTable tb = new DataTable();
            //tb.Columns.Add("PO", typeof(string));
            //tb.Columns.Add("Supplier", typeof(string));
            //tb.Columns.Add("PN", typeof(string));
            //tb.Columns.Add("REV", typeof(string));
            //tb.Columns.Add("QTY", typeof(string));
            //tb.Columns.Add("DATECODE", typeof(string));
            //tb.Columns.Add("DN", typeof(string));
            //tb.Columns.Add("WO", typeof(string));
            //tb.Columns.Add("PALLET_NO", typeof(string));
            //tb.Columns.Add("DATE", typeof(string));
            //tb.Columns.Add("REMARK", typeof(string));
            //tb.Rows.Add("1142691", "GOOD PRODUCT Company", "910-884-00", "A", "10", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142691", "GOOD PRODUCT Company", "910-885-00", "B", "100", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142691", "GOOD PRODUCT Company", "910-886-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "910-886-00", "A", "11", "20160311", "AK81033833", "126396", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "910-881-00", "B", "102", "20160311", "AK81033833", "126396", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "910-884-00", "A", "10", "20160311", "AK81033833", "126396", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "910-883-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "883-884-00", "A", "101", "20160311", "AK81033833", "126397", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "954-885-00", "B", "202", "20160311", "AK81033833", "126397", "P2016050301", "", "");
            //tb.Rows.Add("1142692", "GOOD PRODUCT Company", "888-886-00", "C", "90", "20160311", "AK81033833", "126397", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-884-00", "A", "10", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-886-00", "B", "100", "20160311", "AK81033833", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-886-00", "C", "90", "20160311", "AK81033834", "126395", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-884-00", "A", "10", "20160311", "AK81033834", "126398", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-886-00", "B", "100", "20160311", "AK81033834", "126398", "P2016050301", "", "");
            //tb.Rows.Add("1142693", "GOOD PRODUCT Company", "910-886-00", "C", "90", "20160311", "AK81033833", "126398", "P2016050301", "", "");
            //tb.Rows.Add("1142661", "GOOD PRODUCT Company", "910-884-00", "A", "11", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142661", "GOOD PRODUCT Company", "910-885-00", "B", "102", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142661", "GOOD PRODUCT Company", "910-886-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "GOOD PRODUCT Company", "910-886-00", "A", "101", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "GOOD PRODUCT Company", "910-881-00", "B", "202", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "GOOD PRODUCT Company", "910-883-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "883-884-00", "A", "10", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "954-885-00", "B", "100", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "888-886-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142661", "ABC Company", "910-884-00", "A", "11", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142661", "ABC Company", "910-885-00", "B", "102", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142661", "ABC Company", "910-886-00", "C", "90", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "ABC Company", "910-886-00", "A", "101", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "GOOD PRODUCT Company", "910-881-00", "B", "202", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142662", "GOOD PRODUCT Company", "910-883-00", "C", "101", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "883-884-00", "A", "202", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "954-885-00", "B", "90", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            //tb.Rows.Add("1142664", "GOOD PRODUCT Company", "888-886-00", "A", "10", "20160311", "AK81033833", "126395", "P2016050302", "", "");
            
            

            #endregion

            this.asn.Clear();

            if (!this.CheckDataPassed()) return;

            DataTable tb = this.gridDesktop.Worksheets[0].ExportDataTable(0, 0, this.gridDesktop.Worksheets[0].RowsCount, this.gridDesktop.Worksheets[0].ColumnsCount, true, true);
            tb.NullValueAsEmpty();
            this.asn.Merge(tb.ToASNDataSet());


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.btPrint1D.Enabled = false;
            this.btPrint2D.Enabled = false;
            this.btPreview2D.Enabled = false;
            this.btCloseFile.Enabled = false;
        }

        private void btLoadExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = this.openFileDialog.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.gridDesktop.Clear();
                this.gridDesktop.ImportExcelFile(this.openFileDialog.FileName);
                this.bsiOfExcelPath.Caption = this.openFileDialog.FileName;
                this.btPrint1D.Enabled = true;
                this.btPrint2D.Enabled = true;
                this.btPreview2D.Enabled = true;
                this.btCloseFile.Enabled = true;
                this.gridDesktop.Worksheets[0].IntelligentSkip();
            }
        }

        private void btPrint1D_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.LoadData();

            //if (this.asn.ASN_MST.Count > 0)
            //{
            //    Barcode1DReport report = new Barcode1DReport();
            //    report.SetDataSet(this.asn);
            //    report.Preview();
            //}
        }

        private void btPrint2D_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData();

            if (this.asn.ASN_MST.Count > 0)
            {
                if (this.printDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    Barcode2DReport report = new Barcode2DReport();
                    report.SetDataSet(this.asn);
                    report.DoPrint(this.printDialog.PrinterSettings.PrinterName);
                }
            }
            else
            {
                Messenger.ShowMessage(this, "当前文档没有任何数据,无法进行打印操作!");
            }
        }

        private void btPreview2D_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData();
            if (this.asn.ASN_MST.Count > 0)
            {
                Barcode2DReport report = new Barcode2DReport();
                report.SetDataSet(this.asn);
                report.DisplayName = "ERGOTRON_ReceiptTraveler2DBarcode";
                report.Name = "ERGOTRON_ReceiptTraveler2DBarcode";
                report.Preview();
            }
        }

        private void btCloseFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridDesktop.Clear();
            this.btPrint1D.Enabled = false;
            this.btPrint2D.Enabled = false;
            this.btPreview2D.Enabled = false;
            this.btCloseFile.Enabled = false;
            this.bsiOfExcelPath.Caption = "Ready";
        }


    }
}