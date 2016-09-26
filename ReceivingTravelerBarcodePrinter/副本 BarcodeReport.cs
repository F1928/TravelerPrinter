using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ReceivingTravelerBarcodePrinter
{
    public partial class BarcodeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BarcodeReport()
        {
            InitializeComponent();
            this.xrBarCodeEnter.Text = "\r";
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
