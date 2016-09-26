using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace ReceivingTravelerBarcodePrinter
{
    public partial class Barcode2DReport : DevExpress.XtraReports.UI.XtraReport
    {
        public Barcode2DReport()
        {
            InitializeComponent();
            this.xrBarCodeEnter.Text = string.Format("{0}{0}{1}{2}",(char)Keys.Tab,(char)Keys.Enter,2);
        }

        public void SetDataSet(ASN asnDs)
        {
            this.asn.Clear();
            this.asn.Merge(asnDs);
        }

        public void Preview()
        {
            this.ShowPreview();
        }

        public void RibbonPreview()
        {
            this.ShowRibbonPreview();
        }

        public void DoPrint(string printerName)
        {
            this.Print(printerName);
        }
    }
}
