using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ReceivingTravelerBarcodePrinter
{
    public partial class Barcode1DReport : DevExpress.XtraReports.UI.XtraReport
    {
        public Barcode1DReport()
        {
            InitializeComponent();
            this.xrBarCodeEnter.Text = string.Format("{0}{0}{1}{2}", (char)Keys.Tab, (char)Keys.Enter, 2);
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

        public void Print(string printerName)
        {
            this.Print(printerName);
        }
    }
}
