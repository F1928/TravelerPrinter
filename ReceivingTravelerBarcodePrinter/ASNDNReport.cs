using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ReceivingTravelerBarcodePrinter
{
    public partial class ASNDNReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ASNDNReport()
        {
            InitializeComponent();
        }

        public void SetDataSet(ASN asnDs)
        {
            this.asn.Clear();
            this.asn.Merge(asnDs);
        }

        public string Customer
        {
            get { return this.xrLabelCustomer.Text; }
            set { this.xrLabelCustomer.Text = value; }
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
