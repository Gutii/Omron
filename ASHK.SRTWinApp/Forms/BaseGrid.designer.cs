
namespace ASHK.SRTApp.Forms
{
    partial class BaseGrid
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExport = new DevExpress.XtraBars.BarSubItem();
            this.mnuExportHtml = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportRtf = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportMht = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportXls = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportTXT = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportCSV = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiRefresh,
            this.bbiPrintPreview,
            this.mnuExport,
            this.mnuExportHtml,
            this.mnuExportPdf,
            this.mnuExportRtf,
            this.mnuExportMht,
            this.mnuExportXls,
            this.mnuExportXLSX,
            this.mnuExportTXT,
            this.mnuExportCSV,
            this.bsiRecordsCount});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Обновить";
            this.bbiRefresh.Id = 1;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Просмотр";
            this.bbiPrintPreview.Id = 2;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // mnuExport
            // 
            this.mnuExport.Caption = "Экспорт";
            this.mnuExport.Id = 3;
            this.mnuExport.ImageOptions.ImageUri.Uri = "ExportFile";
            this.mnuExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportHtml),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportRtf),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportMht),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportXls),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportXLSX),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportTXT),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportCSV)});
            this.mnuExport.Name = "mnuExport";
            // 
            // mnuExportHtml
            // 
            this.mnuExportHtml.Caption = "HTML";
            this.mnuExportHtml.Id = 4;
            this.mnuExportHtml.ImageOptions.ImageUri.Uri = "ExportToHTML";
            this.mnuExportHtml.Name = "mnuExportHtml";
            this.mnuExportHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportHtml_ItemClick);
            // 
            // mnuExportPdf
            // 
            this.mnuExportPdf.Caption = "PDF";
            this.mnuExportPdf.Id = 5;
            this.mnuExportPdf.ImageOptions.ImageUri.Uri = "export/exporttopdf";
            this.mnuExportPdf.Name = "mnuExportPdf";
            this.mnuExportPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportPdf_ItemClick);
            // 
            // mnuExportRtf
            // 
            this.mnuExportRtf.Caption = "RTF";
            this.mnuExportRtf.Id = 6;
            this.mnuExportRtf.ImageOptions.ImageUri.Uri = "ExportToRTF";
            this.mnuExportRtf.Name = "mnuExportRtf";
            this.mnuExportRtf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportRtf_ItemClick);
            // 
            // mnuExportMht
            // 
            this.mnuExportMht.Caption = "MHT";
            this.mnuExportMht.Id = 7;
            this.mnuExportMht.ImageOptions.ImageUri.Uri = "ExportToMHT";
            this.mnuExportMht.Name = "mnuExportMht";
            this.mnuExportMht.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportMht_ItemClick);
            // 
            // mnuExportXls
            // 
            this.mnuExportXls.Caption = "XLS";
            this.mnuExportXls.Id = 8;
            this.mnuExportXls.ImageOptions.ImageUri.Uri = "ExportToXLS";
            this.mnuExportXls.Name = "mnuExportXls";
            this.mnuExportXls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportXls_ItemClick);
            // 
            // mnuExportXLSX
            // 
            this.mnuExportXLSX.Caption = "XLSX";
            this.mnuExportXLSX.Id = 9;
            this.mnuExportXLSX.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.mnuExportXLSX.Name = "mnuExportXLSX";
            this.mnuExportXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportXLSX_ItemClick);
            // 
            // mnuExportTXT
            // 
            this.mnuExportTXT.Caption = "TXT";
            this.mnuExportTXT.Id = 10;
            this.mnuExportTXT.ImageOptions.ImageUri.Uri = "ExportToTXT";
            this.mnuExportTXT.Name = "mnuExportTXT";
            this.mnuExportTXT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportTXT_ItemClick);
            // 
            // mnuExportCSV
            // 
            this.mnuExportCSV.Caption = "CSV";
            this.mnuExportCSV.Id = 11;
            this.mnuExportCSV.ImageOptions.ImageUri.Uri = "ExportToCSV";
            this.mnuExportCSV.Name = "mnuExportCSV";
            this.mnuExportCSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportCSV_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiRecordsCount.Caption = "Записей : 0";
            this.bsiRecordsCount.Hint = "Количество записей";
            this.bsiRecordsCount.Id = 12;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Действия";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuExport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Печать и экспорт";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 268);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsLayout.StoreFormatRules = true;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // BaseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaseGrid";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "BaseGrid";
            this.Load += new System.EventHandler(this.BaseGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarSubItem mnuExport;
        private DevExpress.XtraBars.BarButtonItem mnuExportHtml;
        private DevExpress.XtraBars.BarButtonItem mnuExportPdf;
        private DevExpress.XtraBars.BarButtonItem mnuExportRtf;
        private DevExpress.XtraBars.BarButtonItem mnuExportMht;
        private DevExpress.XtraBars.BarButtonItem mnuExportXls;
        private DevExpress.XtraBars.BarButtonItem mnuExportXLSX;
        private DevExpress.XtraBars.BarButtonItem mnuExportTXT;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem mnuExportCSV;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
    }
}