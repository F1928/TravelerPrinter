namespace ReceivingTravelerBarcodePrinter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridDesktop = new Aspose.Cells.GridDesktop.GridDesktop();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.asn = new ReceivingTravelerBarcodePrinter.ASN();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btLoadExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btPrint2D = new DevExpress.XtraBars.BarButtonItem();
            this.btPreview2D = new DevExpress.XtraBars.BarButtonItem();
            this.btPrint1D = new DevExpress.XtraBars.BarButtonItem();
            this.btCloseFile = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiOfExcelPath = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridDesktop);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(676, 499);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridDesktop
            // 
            this.gridDesktop.ActiveSheetIndex = 0;
            this.gridDesktop.ActiveSheetNameFont = null;
            this.gridDesktop.CommentDisplayingFont = new System.Drawing.Font("Arial", 9F);
            this.gridDesktop.IsHorizontalScrollBarVisible = true;
            this.gridDesktop.IsVerticalScrollBarVisible = true;
            this.gridDesktop.Location = new System.Drawing.Point(5, 5);
            this.gridDesktop.Name = "gridDesktop";
            this.gridDesktop.SheetNameFont = new System.Drawing.Font("Verdana", 8F);
            this.gridDesktop.Size = new System.Drawing.Size(666, 489);
            this.gridDesktop.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(676, 499);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridDesktop;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(670, 493);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*xls)|*.xls";
            // 
            // asn
            // 
            this.asn.DataSetName = "ASN";
            this.asn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btLoadExcel,
            this.btPrint1D,
            this.btPrint2D,
            this.bsiOfExcelPath,
            this.btPreview2D,
            this.btCloseFile});
            this.barManager.MaxItemId = 6;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btLoadExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btPrint2D, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btPreview2D, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btPrint1D, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btCloseFile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btLoadExcel
            // 
            this.btLoadExcel.Caption = "Load";
            this.btLoadExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btLoadExcel.Glyph")));
            this.btLoadExcel.Id = 0;
            this.btLoadExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btLoadExcel.LargeGlyph")));
            this.btLoadExcel.Name = "btLoadExcel";
            this.btLoadExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btLoadExcel_ItemClick);
            // 
            // btPrint2D
            // 
            this.btPrint2D.Caption = "Print(2D)";
            this.btPrint2D.Glyph = ((System.Drawing.Image)(resources.GetObject("btPrint2D.Glyph")));
            this.btPrint2D.Id = 2;
            this.btPrint2D.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btPrint2D.LargeGlyph")));
            this.btPrint2D.Name = "btPrint2D";
            this.btPrint2D.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPrint2D_ItemClick);
            // 
            // btPreview2D
            // 
            this.btPreview2D.Caption = "Preview";
            this.btPreview2D.Glyph = ((System.Drawing.Image)(resources.GetObject("btPreview2D.Glyph")));
            this.btPreview2D.Id = 4;
            this.btPreview2D.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btPreview2D.LargeGlyph")));
            this.btPreview2D.Name = "btPreview2D";
            this.btPreview2D.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPreview2D_ItemClick);
            // 
            // btPrint1D
            // 
            this.btPrint1D.Caption = "Print(1D)";
            this.btPrint1D.Glyph = ((System.Drawing.Image)(resources.GetObject("btPrint1D.Glyph")));
            this.btPrint1D.Id = 1;
            this.btPrint1D.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btPrint1D.LargeGlyph")));
            this.btPrint1D.Name = "btPrint1D";
            this.btPrint1D.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btPrint1D.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPrint1D_ItemClick);
            // 
            // btCloseFile
            // 
            this.btCloseFile.Caption = "Close";
            this.btCloseFile.Glyph = ((System.Drawing.Image)(resources.GetObject("btCloseFile.Glyph")));
            this.btCloseFile.Id = 5;
            this.btCloseFile.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btCloseFile.LargeGlyph")));
            this.btCloseFile.Name = "btCloseFile";
            this.btCloseFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btCloseFile_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiOfExcelPath)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bsiOfExcelPath
            // 
            this.bsiOfExcelPath.Caption = "Ready";
            this.bsiOfExcelPath.Id = 3;
            this.bsiOfExcelPath.Name = "bsiOfExcelPath";
            this.bsiOfExcelPath.Size = new System.Drawing.Size(800, 0);
            this.bsiOfExcelPath.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(676, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            this.barDockControlBottom.Size = new System.Drawing.Size(676, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(676, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 549);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ReceivingTraveler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Aspose.Cells.GridDesktop.GridDesktop gridDesktop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ASN asn;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btLoadExcel;
        private DevExpress.XtraBars.BarButtonItem btPrint1D;
        private DevExpress.XtraBars.BarButtonItem btPrint2D;
        private DevExpress.XtraBars.BarStaticItem bsiOfExcelPath;
        private DevExpress.XtraBars.BarButtonItem btPreview2D;
        private System.Windows.Forms.PrintDialog printDialog;
        private DevExpress.XtraBars.BarButtonItem btCloseFile;
    }
}