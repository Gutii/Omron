
namespace ASHK.SRTApp.Forms
{
    partial class Main
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accScales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accFormScales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accWeghing = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accRawTire = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accElemSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accElemConnectDB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accInfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accReautoristion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.flyoutPanel2 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel2)).BeginInit();
            this.flyoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accScales,
            this.accSettings});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.Size = new System.Drawing.Size(48, 518);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accScales
            // 
            this.accScales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accFormScales,
            this.accWeghing,
            this.accRawTire});
            this.accScales.Expanded = true;
            this.accScales.Hint = "Весы";
            this.accScales.ImageOptions.ImageUri.Uri = "dashboards/weightedpies";
            this.accScales.Name = "accScales";
            this.accScales.Text = "Весы";
            // 
            // accFormScales
            // 
            this.accFormScales.ImageOptions.ImageUri.Uri = "dashboards/weightedpies";
            this.accFormScales.Name = "accFormScales";
            this.accFormScales.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accFormScales.Text = "Взвесить";
            this.accFormScales.Click += new System.EventHandler(this.accFormScales_Click);
            // 
            // accWeghing
            // 
            this.accWeghing.ImageOptions.ImageUri.Uri = "business%20objects/bo_list";
            this.accWeghing.Name = "accWeghing";
            this.accWeghing.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accWeghing.Text = "Взвешивания";
            this.accWeghing.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accRawTire
            // 
            this.accRawTire.ImageOptions.ImageUri.Uri = "chart/charttype_doughnut";
            this.accRawTire.Name = "accRawTire";
            this.accRawTire.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accRawTire.Text = "Сырые покрышки";
            this.accRawTire.Click += new System.EventHandler(this.accRawTire_Click);
            // 
            // accSettings
            // 
            this.accSettings.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
            this.accSettings.Hint = "Настройки";
            this.accSettings.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.accSettings.Name = "accSettings";
            this.accSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accSettings.Text = "Настройки";
            this.accSettings.Click += new System.EventHandler(this.accSettings_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(868, 0);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Выход";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem1.Caption = "Окна";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barMdiChildrenListItem1,
            this.barMdiChildrenListItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(730, 0);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem2.Caption = "Окна";
            this.barMdiChildrenListItem2.Id = 10;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barMdiChildrenListItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(48, 491);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(820, 27);
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem});
            this.ribbonControl2.Location = new System.Drawing.Point(48, 0);
            this.ribbonControl2.MaxItemId = 1;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(820, 26);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(490, 79);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton(),
            new DevExpress.Utils.PeekFormButton()});
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(210, 301);
            this.flyoutPanel1.TabIndex = 6;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.accordionControl2);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(210, 301);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // accordionControl2
            // 
            this.accordionControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accUpdate,
            this.accInfo,
            this.accReautoristion,
            this.accExit});
            this.accordionControl2.ExpandGroupOnHeaderClick = false;
            this.accordionControl2.ExpandItemOnHeaderClick = false;
            this.accordionControl2.Location = new System.Drawing.Point(2, 2);
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.ShowGroupExpandButtons = false;
            this.accordionControl2.ShowItemExpandButtons = false;
            this.accordionControl2.Size = new System.Drawing.Size(206, 297);
            this.accordionControl2.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accElemSettings,
            this.accElemConnectDB});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Настройки";
            // 
            // accElemSettings
            // 
            this.accElemSettings.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.accElemSettings.Name = "accElemSettings";
            this.accElemSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accElemSettings.Text = "Настройки";
            this.accElemSettings.Click += new System.EventHandler(this.accElemSettings_Click);
            // 
            // accElemConnectDB
            // 
            this.accElemConnectDB.ImageOptions.ImageUri.Uri = "dashboards/editconnection";
            this.accElemConnectDB.Name = "accElemConnectDB";
            this.accElemConnectDB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accElemConnectDB.Text = "Подключение к БД";
            this.accElemConnectDB.Click += new System.EventHandler(this.accElemConnectDB_Click);
            // 
            // accUpdate
            // 
            this.accUpdate.ImageOptions.ImageUri.Uri = "dashboards/automaticupdates";
            this.accUpdate.Name = "accUpdate";
            this.accUpdate.Text = "Обновить";
            this.accUpdate.Click += new System.EventHandler(this.accordionControlElement2_Click_1);
            // 
            // accInfo
            // 
            this.accInfo.ImageOptions.ImageUri.Uri = "icon%20builder/actions_info";
            this.accInfo.Name = "accInfo";
            this.accInfo.Text = "О программе...";
            this.accInfo.Click += new System.EventHandler(this.accInfo_Click);
            // 
            // accReautoristion
            // 
            this.accReautoristion.ImageOptions.ImageUri.Uri = "Recurrence";
            this.accReautoristion.Name = "accReautoristion";
            this.accReautoristion.Text = "переавторизоваться";
            this.accReautoristion.Click += new System.EventHandler(this.accReautoristion_Click);
            // 
            // accExit
            // 
            this.accExit.ImageOptions.ImageUri.Uri = "Cancel";
            this.accExit.Name = "accExit";
            this.accExit.Text = "Выход";
            this.accExit.Click += new System.EventHandler(this.accExit_Click);
            // 
            // flyoutPanel2
            // 
            this.flyoutPanel2.Controls.Add(this.flyoutPanelControl2);
            this.flyoutPanel2.Location = new System.Drawing.Point(667, 465);
            this.flyoutPanel2.Name = "flyoutPanel2";
            this.flyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel2.Options.CloseOnOuterClick = true;
            this.flyoutPanel2.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.flyoutPanel2.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            this.flyoutPanel2.OwnerControl = this.ribbonStatusBar1;
            this.flyoutPanel2.Size = new System.Drawing.Size(200, 26);
            this.flyoutPanel2.TabIndex = 9;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.panel1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = this.flyoutPanel2;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(200, 26);
            this.flyoutPanelControl2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 22);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступно новое обновление";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 518);
            this.Controls.Add(this.flyoutPanel2);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.IconOptions.ImageUri.Uri = "dashboards/weightedpies";
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(870, 550);
            this.Name = "Main";
            this.Text = "Клиент для взвешивания сырых покрышек";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel2)).EndInit();
            this.flyoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accScales;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accFormScales;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accElemSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accElemConnectDB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accExit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accInfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accWeghing;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accRawTire;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accReautoristion;
        private DevExpress.Utils.FlyoutPanel flyoutPanel2;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accUpdate;
    }
}