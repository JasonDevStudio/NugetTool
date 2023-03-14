namespace NuigetTool
{
    partial class FrmNuGetTool
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuGetTool));
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            medLog = new DevExpress.XtraEditors.MemoEdit();
            chePreview = new DevExpress.XtraEditors.CheckEdit();
            grdVersions = new DevExpress.XtraGrid.GridControl();
            searchResultVersionBindingSource = new System.Windows.Forms.BindingSource(components);
            grvVersions = new DevExpress.XtraGrid.Views.Grid.GridView();
            colRegistrationLeafUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colDownloads = new DevExpress.XtraGrid.Columns.GridColumn();
            grdPackages = new DevExpress.XtraGrid.GridControl();
            searchResultBindingSource = new System.Windows.Forms.BindingSource(components);
            grvPackages = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPackageId = new DevExpress.XtraGrid.Columns.GridColumn();
            colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colAuthors = new DevExpress.XtraGrid.Columns.GridColumn();
            colIconUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            colLicenseUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            colProjectUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            colRegistrationIndexUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            colTags = new DevExpress.XtraGrid.Columns.GridColumn();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalDownloads = new DevExpress.XtraGrid.Columns.GridColumn();
            colVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            txtKeys = new DevExpress.XtraEditors.MemoEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            log = new DevExpress.XtraLayout.LayoutControlItem();
            tnpMain = new DevExpress.XtraBars.Navigation.TileNavPane();
            btnSearch = new DevExpress.XtraBars.Navigation.NavButton();
            btnDetail = new DevExpress.XtraBars.Navigation.NavButton();
            btnOpen = new DevExpress.XtraBars.Navigation.NavButton();
            btnDownlaod = new DevExpress.XtraBars.Navigation.NavButton();
            btnDownLoads = new DevExpress.XtraBars.Navigation.NavButton();
            packageMetadataBindingSource = new System.Windows.Forms.BindingSource(components);
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            btnBatchDownload = new DevExpress.XtraBars.Navigation.NavButton();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medLog.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chePreview.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdVersions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchResultVersionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvVersions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchResultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKeys.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)log).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnpMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packageMetadataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(layoutControl1);
            fluentDesignFormContainer1.Controls.Add(tnpMain);
            fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 31);
            fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new System.Drawing.Size(1324, 882);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(medLog);
            layoutControl1.Controls.Add(chePreview);
            layoutControl1.Controls.Add(grdVersions);
            layoutControl1.Controls.Add(grdPackages);
            layoutControl1.Controls.Add(txtKeys);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 31);
            layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(952, 471, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1324, 851);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // medLog
            // 
            medLog.Location = new System.Drawing.Point(24, 640);
            medLog.Name = "medLog";
            medLog.Size = new System.Drawing.Size(1276, 187);
            medLog.StyleController = layoutControl1;
            medLog.TabIndex = 10;
            // 
            // chePreview
            // 
            chePreview.EditValue = true;
            chePreview.Location = new System.Drawing.Point(1228, 47);
            chePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chePreview.Name = "chePreview";
            chePreview.Properties.Caption = "Preview";
            chePreview.Size = new System.Drawing.Size(70, 20);
            chePreview.StyleController = layoutControl1;
            chePreview.TabIndex = 9;
            // 
            // grdVersions
            // 
            grdVersions.DataSource = searchResultVersionBindingSource;
            grdVersions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grdVersions.Location = new System.Drawing.Point(979, 73);
            grdVersions.MainView = grvVersions;
            grdVersions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grdVersions.Name = "grdVersions";
            grdVersions.Size = new System.Drawing.Size(321, 563);
            grdVersions.TabIndex = 8;
            grdVersions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvVersions });
            // 
            // searchResultVersionBindingSource
            // 
            searchResultVersionBindingSource.DataSource = typeof(BaGet.Protocol.Models.SearchResultVersion);
            // 
            // grvVersions
            // 
            grvVersions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colRegistrationLeafUrl, colVersion1, colDownloads });
            grvVersions.DetailHeight = 272;
            grvVersions.GridControl = grdVersions;
            grvVersions.Name = "grvVersions";
            grvVersions.OptionsBehavior.Editable = false;
            // 
            // colRegistrationLeafUrl
            // 
            colRegistrationLeafUrl.FieldName = "RegistrationLeafUrl";
            colRegistrationLeafUrl.MinWidth = 22;
            colRegistrationLeafUrl.Name = "colRegistrationLeafUrl";
            colRegistrationLeafUrl.Visible = true;
            colRegistrationLeafUrl.VisibleIndex = 0;
            colRegistrationLeafUrl.Width = 82;
            // 
            // colVersion1
            // 
            colVersion1.FieldName = "Version";
            colVersion1.MinWidth = 22;
            colVersion1.Name = "colVersion1";
            colVersion1.Visible = true;
            colVersion1.VisibleIndex = 1;
            colVersion1.Width = 82;
            // 
            // colDownloads
            // 
            colDownloads.FieldName = "Downloads";
            colDownloads.MinWidth = 22;
            colDownloads.Name = "colDownloads";
            colDownloads.Width = 82;
            // 
            // grdPackages
            // 
            grdPackages.DataSource = searchResultBindingSource;
            grdPackages.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grdPackages.Location = new System.Drawing.Point(24, 73);
            grdPackages.MainView = grvPackages;
            grdPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grdPackages.Name = "grdPackages";
            grdPackages.Size = new System.Drawing.Size(951, 563);
            grdPackages.TabIndex = 5;
            grdPackages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvPackages });
            // 
            // searchResultBindingSource
            // 
            searchResultBindingSource.DataSource = typeof(BaGet.Protocol.Models.SearchResult);
            // 
            // grvPackages
            // 
            grvPackages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPackageId, colVersion, colDescription, colAuthors, colIconUrl, colLicenseUrl, colProjectUrl, colRegistrationIndexUrl, colSummary, colTags, colTitle, colTotalDownloads, colVersions });
            grvPackages.DetailHeight = 272;
            grvPackages.GridControl = grdPackages;
            grvPackages.Name = "grvPackages";
            grvPackages.OptionsBehavior.Editable = false;
            grvPackages.OptionsDetail.AllowExpandEmptyDetails = true;
            grvPackages.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            grvPackages.OptionsDetail.AutoZoomDetail = true;
            grvPackages.OptionsFind.AlwaysVisible = true;
            grvPackages.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            grvPackages.OptionsSelection.MultiSelect = true;
            grvPackages.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            grvPackages.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colTitle, DevExpress.Data.ColumnSortOrder.Descending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colVersion, DevExpress.Data.ColumnSortOrder.Descending) });
            grvPackages.RowClick += grvPackages_RowClick;
            // 
            // colPackageId
            // 
            colPackageId.FieldName = "PackageId";
            colPackageId.MinWidth = 22;
            colPackageId.Name = "colPackageId";
            colPackageId.Visible = true;
            colPackageId.VisibleIndex = 1;
            colPackageId.Width = 231;
            // 
            // colVersion
            // 
            colVersion.FieldName = "Version";
            colVersion.MinWidth = 22;
            colVersion.Name = "colVersion";
            colVersion.Visible = true;
            colVersion.VisibleIndex = 2;
            colVersion.Width = 132;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.MinWidth = 22;
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 3;
            colDescription.Width = 132;
            // 
            // colAuthors
            // 
            colAuthors.FieldName = "Authors";
            colAuthors.MinWidth = 22;
            colAuthors.Name = "colAuthors";
            colAuthors.Width = 132;
            // 
            // colIconUrl
            // 
            colIconUrl.FieldName = "IconUrl";
            colIconUrl.MinWidth = 22;
            colIconUrl.Name = "colIconUrl";
            colIconUrl.Width = 132;
            // 
            // colLicenseUrl
            // 
            colLicenseUrl.FieldName = "LicenseUrl";
            colLicenseUrl.MinWidth = 22;
            colLicenseUrl.Name = "colLicenseUrl";
            colLicenseUrl.Width = 132;
            // 
            // colProjectUrl
            // 
            colProjectUrl.FieldName = "ProjectUrl";
            colProjectUrl.MinWidth = 22;
            colProjectUrl.Name = "colProjectUrl";
            colProjectUrl.Visible = true;
            colProjectUrl.VisibleIndex = 4;
            colProjectUrl.Width = 132;
            // 
            // colRegistrationIndexUrl
            // 
            colRegistrationIndexUrl.FieldName = "RegistrationIndexUrl";
            colRegistrationIndexUrl.MinWidth = 22;
            colRegistrationIndexUrl.Name = "colRegistrationIndexUrl";
            colRegistrationIndexUrl.Width = 132;
            // 
            // colSummary
            // 
            colSummary.FieldName = "Summary";
            colSummary.MinWidth = 22;
            colSummary.Name = "colSummary";
            colSummary.Width = 132;
            // 
            // colTags
            // 
            colTags.FieldName = "Tags";
            colTags.MinWidth = 22;
            colTags.Name = "colTags";
            colTags.Width = 132;
            // 
            // colTitle
            // 
            colTitle.FieldName = "Title";
            colTitle.MinWidth = 22;
            colTitle.Name = "colTitle";
            colTitle.Width = 189;
            // 
            // colTotalDownloads
            // 
            colTotalDownloads.FieldName = "TotalDownloads";
            colTotalDownloads.MinWidth = 22;
            colTotalDownloads.Name = "colTotalDownloads";
            colTotalDownloads.Visible = true;
            colTotalDownloads.VisibleIndex = 5;
            colTotalDownloads.Width = 132;
            // 
            // colVersions
            // 
            colVersions.FieldName = "Versions";
            colVersions.MinWidth = 22;
            colVersions.Name = "colVersions";
            colVersions.Width = 152;
            // 
            // txtKeys
            // 
            txtKeys.Location = new System.Drawing.Point(108, 47);
            txtKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKeys.Name = "txtKeys";
            txtKeys.Size = new System.Drawing.Size(1112, 20);
            txtKeys.StyleController = layoutControl1;
            txtKeys.TabIndex = 4;
            txtKeys.KeyDown += txtKeys_KeyDown;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1324, 851);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, log });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(1304, 831);
            layoutControlGroup1.Text = "Search";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtKeys;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem1.Size = new System.Drawing.Size(1202, 28);
            layoutControlItem1.Text = "Search Keys:";
            layoutControlItem1.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = grdPackages;
            layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(955, 567);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = grdVersions;
            layoutControlItem3.Location = new System.Drawing.Point(955, 28);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(325, 567);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = chePreview;
            layoutControlItem4.Location = new System.Drawing.Point(1202, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem4.Size = new System.Drawing.Size(78, 28);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // log
            // 
            log.Control = medLog;
            log.Location = new System.Drawing.Point(0, 595);
            log.Name = "log";
            log.Size = new System.Drawing.Size(1280, 191);
            log.TextSize = new System.Drawing.Size(0, 0);
            log.TextVisible = false;
            // 
            // tnpMain
            // 
            tnpMain.Buttons.Add(btnSearch);
            tnpMain.Buttons.Add(btnDetail);
            tnpMain.Buttons.Add(btnOpen);
            tnpMain.Buttons.Add(btnDownlaod);
            tnpMain.Buttons.Add(btnDownLoads);
            tnpMain.Buttons.Add(btnBatchDownload);
            // 
            // tileNavCategory1
            // 
            tnpMain.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            tnpMain.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tnpMain.Dock = System.Windows.Forms.DockStyle.Top;
            tnpMain.Location = new System.Drawing.Point(0, 0);
            tnpMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tnpMain.Name = "tnpMain";
            tnpMain.Size = new System.Drawing.Size(1324, 31);
            tnpMain.TabIndex = 0;
            tnpMain.Text = "tileNavPane1";
            // 
            // btnSearch
            // 
            btnSearch.Caption = "Search";
            btnSearch.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSearch.ImageOptions.Image");
            btnSearch.Name = "btnSearch";
            btnSearch.ElementClick += btnSearch_ElementClick;
            // 
            // btnDetail
            // 
            btnDetail.Caption = "Detail";
            btnDetail.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDetail.ImageOptions.Image");
            btnDetail.Name = "btnDetail";
            btnDetail.ElementClick += btnDetail_ElementClick;
            // 
            // btnOpen
            // 
            btnOpen.Caption = "Open";
            btnOpen.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOpen.ImageOptions.Image");
            btnOpen.Name = "btnOpen";
            btnOpen.ElementClick += btnOpen_ElementClick;
            // 
            // btnDownlaod
            // 
            btnDownlaod.Caption = "Download";
            btnDownlaod.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDownlaod.ImageOptions.Image");
            btnDownlaod.Name = "btnDownlaod";
            btnDownlaod.ElementClick += btnDownlaod_ElementClick;
            // 
            // btnDownLoads
            // 
            btnDownLoads.Caption = "DownLoads";
            btnDownLoads.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDownLoads.ImageOptions.Image");
            btnDownLoads.Name = "btnDownLoads";
            btnDownLoads.ElementClick += btnDownLoads_ElementClick;
            // 
            // packageMetadataBindingSource
            // 
            packageMetadataBindingSource.DataSource = typeof(BaGet.Protocol.Models.PackageMetadata);
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1324, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // btnBatchDownload
            // 
            btnBatchDownload.Caption = "BatchDownload";
            btnBatchDownload.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBatchDownload.ImageOptions.Image");
            btnBatchDownload.Name = "btnBatchDownload";
            btnBatchDownload.ElementClick += btnBatchDownload_ElementClick;
            // 
            // FrmNuGetTool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1324, 913);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmNuGetTool";
            Text = "Nuget Tool";
            TransparencyKey = System.Drawing.Color.FromArgb(250, 250, 255);
            Load += FrmNuGetTool_Load;
            fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)medLog.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chePreview.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdVersions).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchResultVersionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvVersions).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdPackages).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchResultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvPackages).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKeys.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)log).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnpMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)packageMetadataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.TileNavPane tnpMain;
        private DevExpress.XtraBars.Navigation.NavButton btnOpen;
        private DevExpress.XtraBars.Navigation.NavButton btnSearch;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Navigation.NavButton btnDetail;
        private DevExpress.XtraEditors.MemoEdit txtKeys;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl grdPackages;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPackages;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource searchResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageId;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthors;
        private DevExpress.XtraGrid.Columns.GridColumn colIconUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationIndexUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colTags;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDownloads;
        private DevExpress.XtraGrid.Columns.GridColumn colVersions;
        private System.Windows.Forms.BindingSource packageMetadataBindingSource;
        private DevExpress.XtraGrid.GridControl grdVersions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvVersions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource searchResultVersionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationLeafUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDownloads;
        private DevExpress.XtraEditors.CheckEdit chePreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Navigation.NavButton btnDownlaod;
        private DevExpress.XtraEditors.MemoEdit medLog;
        private DevExpress.XtraLayout.LayoutControlItem log;
        private DevExpress.XtraBars.Navigation.NavButton btnDownLoads;
        private DevExpress.XtraBars.Navigation.NavButton btnBatchDownload;
    }
}

