namespace QLHocSinhTHPT
{
    partial class frmMain
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
            System.Windows.Forms.DialogResult rs;
            rs = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình Quản lý điểm học sinh không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
        }

        #region Windows Form Designer generated code
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanelQuanLy = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarGiaoVien = new DevComponents.DotNetBar.RibbonBar();
            this.btnGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanCong = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarHocSinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainerDanTocTonGiao = new DevComponents.DotNetBar.ItemContainer();
            this.ribbonBarLop = new DevComponents.DotNetBar.RibbonBar();
            this.btnLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuyDinh = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarQuyDinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnDoTuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiSo = new DevComponents.DotNetBar.ButtonItem();
            this.btnThangDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnTruong = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelTraCuu = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarTraCuu = new DevComponents.DotNetBar.RibbonBar();
            this.btnTimKiemHS = new DevComponents.DotNetBar.ButtonItem();
            this.btnTimKiemGV = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabTraCuu = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuyDinh = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemGroup = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.bottomBar = new DevComponents.DotNetBar.Bar();
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.lblNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.mdiClient = new System.Windows.Forms.MdiClient();
            this.ctxMenuMain = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenuMain = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangNhapContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuatContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoiMatKhauContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoatContext = new DevComponents.DotNetBar.ButtonItem();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelQuanLy.SuspendLayout();
            this.ribbonPanelQuyDinh.SuspendLayout();
            this.ribbonPanelTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelQuanLy);
            this.ribbonControl.Controls.Add(this.ribbonPanelQuyDinh);
            this.ribbonControl.Controls.Add(this.ribbonPanelTraCuu);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabQuanLy,
            this.ribbonTabTraCuu,
            this.ribbonTabQuyDinh});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.Size = new System.Drawing.Size(797, 184);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl.SystemText.MaximizeRibbonText = "Cực &đại menu Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Cực &tiểu menu Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Thêm vào thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "Thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeText = "&Tùy chọn đối tượng hiển thị...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Thêm >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Hủy bỏ";
            this.ribbonControl.SystemText.QatDialogCaption = "TÙY CHỌN ĐỐI TƯỢNG HIỂN THỊ";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Chọn đối tượng từ danh sách:";
            this.ribbonControl.SystemText.QatDialogOkButton = "Đồng ý";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Loại bỏ";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Dời thanh công cụ lên trên menu Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Loại bỏ khỏi thanh công cụ truy xuất nhanh";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabGroups.AddRange(new DevComponents.DotNetBar.RibbonTabItemGroup[] {
            this.ribbonTabItemGroup});
            this.ribbonControl.TabGroupsVisible = true;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanelQuanLy
            // 
            this.ribbonPanelQuanLy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuanLy, this.btnMenuMain);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarGiaoVien);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarHocSinh);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarLop);
            this.ribbonPanelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuanLy.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelQuanLy.Name = "ribbonPanelQuanLy";
            this.ribbonPanelQuanLy.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuanLy.Size = new System.Drawing.Size(797, 126);
            this.ribbonPanelQuanLy.TabIndex = 1;
            // 
            // ribbonBarGiaoVien
            // 
            this.ribbonBarGiaoVien.AutoOverflowEnabled = true;
            this.ribbonBarGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGiaoVien,
            this.btnPhanCong});
            this.ribbonBarGiaoVien.Location = new System.Drawing.Point(381, 0);
            this.ribbonBarGiaoVien.Name = "ribbonBarGiaoVien";
            this.ribbonBarGiaoVien.Size = new System.Drawing.Size(126, 123);
            this.ribbonBarGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarGiaoVien.TabIndex = 6;
            this.ribbonBarGiaoVien.Text = "Giáo Viên";
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Image = global::QLHocSinhTHPT.Properties.Resources.giaovien;
            this.btnGiaoVien.ImagePaddingHorizontal = 8;
            this.btnGiaoVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.SplitButton = true;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.Tooltip = "Giáo viên";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Image = global::QLHocSinhTHPT.Properties.Resources.nghenghiep;
            this.btnPhanCong.ImagePaddingHorizontal = 8;
            this.btnPhanCong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.SplitButton = true;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Tooltip = "Phân công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // ribbonBarHocSinh
            // 
            this.ribbonBarHocSinh.AutoOverflowEnabled = true;
            this.ribbonBarHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarHocSinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocSinh,
            this.itemContainerDanTocTonGiao});
            this.ribbonBarHocSinh.Location = new System.Drawing.Point(129, 0);
            this.ribbonBarHocSinh.Name = "ribbonBarHocSinh";
            this.ribbonBarHocSinh.Size = new System.Drawing.Size(252, 123);
            this.ribbonBarHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarHocSinh.TabIndex = 5;
            this.ribbonBarHocSinh.Text = "Học Sinh";
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Image = global::QLHocSinhTHPT.Properties.Resources.pupils;
            this.btnHocSinh.ImagePaddingHorizontal = 8;
            this.btnHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.SplitButton = true;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Tooltip = "Học sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // itemContainerDanTocTonGiao
            // 
            this.itemContainerDanTocTonGiao.ItemSpacing = 0;
            this.itemContainerDanTocTonGiao.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainerDanTocTonGiao.Name = "itemContainerDanTocTonGiao";
            // 
            // ribbonBarLop
            // 
            this.ribbonBarLop.AutoOverflowEnabled = true;
            this.ribbonBarLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarLop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLopHoc});
            this.ribbonBarLop.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarLop.Name = "ribbonBarLop";
            this.ribbonBarLop.Size = new System.Drawing.Size(126, 123);
            this.ribbonBarLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarLop.TabIndex = 1;
            this.ribbonBarLop.Text = "Lớp";
            this.ribbonBarLop.ItemClick += new System.EventHandler(this.ribbonBarLop_ItemClick);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Image = global::QLHocSinhTHPT.Properties.Resources.start;
            this.btnLopHoc.ImagePaddingHorizontal = 8;
            this.btnLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.SplitButton = true;
            this.btnLopHoc.Text = "<div align=\"center\">Lớp<br/>học</div>";
            this.btnLopHoc.Tooltip = "Lớp học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // ribbonPanelQuyDinh
            // 
            this.ribbonPanelQuyDinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuyDinh, this.btnMenuMain);
            this.ribbonPanelQuyDinh.Controls.Add(this.ribbonBarQuyDinh);
            this.ribbonPanelQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuyDinh.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelQuyDinh.Name = "ribbonPanelQuyDinh";
            this.ribbonPanelQuyDinh.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuyDinh.Size = new System.Drawing.Size(797, 126);
            this.ribbonPanelQuyDinh.TabIndex = 3;
            this.ribbonPanelQuyDinh.Visible = false;
            // 
            // ribbonBarQuyDinh
            // 
            this.ribbonBarQuyDinh.AutoOverflowEnabled = true;
            this.ribbonBarQuyDinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarQuyDinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDoTuoi,
            this.btnSiSo,
            this.btnThangDiem,
            this.btnTruong});
            this.ribbonBarQuyDinh.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarQuyDinh.Name = "ribbonBarQuyDinh";
            this.ribbonBarQuyDinh.Size = new System.Drawing.Size(345, 123);
            this.ribbonBarQuyDinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarQuyDinh.TabIndex = 1;
            this.ribbonBarQuyDinh.Text = "Quy Định Chung";
            // 
            // btnDoTuoi
            // 
            this.btnDoTuoi.Image = global::QLHocSinhTHPT.Properties.Resources.qddotuoi;
            this.btnDoTuoi.ImagePaddingHorizontal = 8;
            this.btnDoTuoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDoTuoi.Name = "btnDoTuoi";
            this.btnDoTuoi.SplitButton = true;
            this.btnDoTuoi.Text = "<div align=\"center\">Quy định<br/>về độ tuổi</div>";
            this.btnDoTuoi.Tooltip = "Quy định về độ tuổi";
            this.btnDoTuoi.Click += new System.EventHandler(this.btnDoTuoi_Click);
            // 
            // btnSiSo
            // 
            this.btnSiSo.Image = global::QLHocSinhTHPT.Properties.Resources.qdsiso;
            this.btnSiSo.ImagePaddingHorizontal = 8;
            this.btnSiSo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSiSo.Name = "btnSiSo";
            this.btnSiSo.SplitButton = true;
            this.btnSiSo.Text = "<div align=\"center\">Quy định<br/>về sỉ số</div>";
            this.btnSiSo.Tooltip = "Quy định về sỉ số";
            this.btnSiSo.Click += new System.EventHandler(this.btnSiSo_Click);
            // 
            // btnThangDiem
            // 
            this.btnThangDiem.Image = global::QLHocSinhTHPT.Properties.Resources.qdthangdiem;
            this.btnThangDiem.ImagePaddingHorizontal = 8;
            this.btnThangDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThangDiem.Name = "btnThangDiem";
            this.btnThangDiem.SplitButton = true;
            this.btnThangDiem.Text = "<div align=\"center\">Quy định<br/>thang điểm</div>";
            this.btnThangDiem.Tooltip = "Quy định về thang điểm";
            this.btnThangDiem.Click += new System.EventHandler(this.btnThangDiem_Click);
            // 
            // btnTruong
            // 
            this.btnTruong.Image = global::QLHocSinhTHPT.Properties.Resources.tttruonghoc;
            this.btnTruong.ImagePaddingHorizontal = 8;
            this.btnTruong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTruong.Name = "btnTruong";
            this.btnTruong.SplitButton = true;
            this.btnTruong.Text = "<div align=\"center\">Thông tin<br/>trường học</div>";
            this.btnTruong.Tooltip = "Thông tin trường học";
            this.btnTruong.Click += new System.EventHandler(this.btnTruong_Click);
            // 
            // ribbonPanelTraCuu
            // 
            this.ribbonPanelTraCuu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelTraCuu, this.btnMenuMain);
            this.ribbonPanelTraCuu.Controls.Add(this.ribbonBarTraCuu);
            this.ribbonPanelTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelTraCuu.Location = new System.Drawing.Point(0, 69);
            this.ribbonPanelTraCuu.Name = "ribbonPanelTraCuu";
            this.ribbonPanelTraCuu.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelTraCuu.Size = new System.Drawing.Size(1091, 112);
            this.ribbonPanelTraCuu.TabIndex = 4;
            this.ribbonPanelTraCuu.Visible = false;
            // 
            // ribbonBarTraCuu
            // 
            this.ribbonBarTraCuu.AutoOverflowEnabled = true;
            this.ribbonBarTraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarTraCuu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimKiemHS,
            this.btnTimKiemGV});
            this.ribbonBarTraCuu.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarTraCuu.Name = "ribbonBarTraCuu";
            this.ribbonBarTraCuu.Size = new System.Drawing.Size(160, 109);
            this.ribbonBarTraCuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarTraCuu.TabIndex = 1;
            this.ribbonBarTraCuu.Text = "Tra Cứu";
            // 
            // btnTimKiemHS
            // 
            this.btnTimKiemHS.Image = global::QLHocSinhTHPT.Properties.Resources.tracuuhocsinh;
            this.btnTimKiemHS.ImagePaddingHorizontal = 8;
            this.btnTimKiemHS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiemHS.Name = "btnTimKiemHS";
            this.btnTimKiemHS.SplitButton = true;
            this.btnTimKiemHS.Text = "<div align=\"center\">Tra cứu<br/>học sinh</div>";
            this.btnTimKiemHS.Tooltip = "Tra cứu học sinh";
            this.btnTimKiemHS.Click += new System.EventHandler(this.btnTimKiemHS_Click);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Image = global::QLHocSinhTHPT.Properties.Resources.tracuugiaovien;
            this.btnTimKiemGV.ImagePaddingHorizontal = 8;
            this.btnTimKiemGV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.SplitButton = true;
            this.btnTimKiemGV.Text = "<div align=\"center\">Tra cứu<br/>giáo viên</div>";
            this.btnTimKiemGV.Tooltip = "Tra cứu giáo viên";
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // ribbonTabQuanLy
            // 
            this.ribbonTabQuanLy.Checked = true;
            this.ribbonTabQuanLy.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy.Name = "ribbonTabQuanLy";
            this.ribbonTabQuanLy.Panel = this.ribbonPanelQuanLy;
            this.ribbonTabQuanLy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.ribbonTabQuanLy.Text = "&Quản lý";
            this.ribbonTabQuanLy.Tooltip = "Quản lý (F2)";
            // 
            // ribbonTabTraCuu
            // 
            this.ribbonTabTraCuu.ImagePaddingHorizontal = 8;
            this.ribbonTabTraCuu.Name = "ribbonTabTraCuu";
            this.ribbonTabTraCuu.Panel = this.ribbonPanelTraCuu;
            this.ribbonTabTraCuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.ribbonTabTraCuu.Text = "Tra cứu";
            this.ribbonTabTraCuu.Tooltip = "Tra cứu (F4)";
            // 
            // ribbonTabQuyDinh
            // 
            this.ribbonTabQuyDinh.ImagePaddingHorizontal = 8;
            this.ribbonTabQuyDinh.Name = "ribbonTabQuyDinh";
            this.ribbonTabQuyDinh.Panel = this.ribbonPanelQuyDinh;
            this.ribbonTabQuyDinh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ribbonTabQuyDinh.Text = "&Quy định";
            this.ribbonTabQuyDinh.Tooltip = "Quy định (F5)";
            this.ribbonTabQuyDinh.Click += new System.EventHandler(this.ribbonTabQuyDinh_Click);
            // 
            // ribbonTabItemGroup
            // 
            this.ribbonTabItemGroup.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup.Name = "ribbonTabItemGroup";
            // 
            // 
            // 
            this.ribbonTabItemGroup.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // bottomBar
            // 
            this.bottomBar.AccessibleDescription = "DotNetBar Bar (bottomBar)";
            this.bottomBar.AccessibleName = "DotNetBar Bar";
            this.bottomBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bottomBar.AlwaysDisplayDockTab = true;
            this.bottomBar.AntiAlias = true;
            this.bottomBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.ctxMenuMain.SetContextMenuEx(this.bottomBar, this.btnMenuMain);
            this.bottomBar.Controls.Add(this.lblTenNguoiDung);
            this.bottomBar.Controls.Add(this.lblNguoiDung);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bottomBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bottomBar.ItemSpacing = 2;
            this.bottomBar.Location = new System.Drawing.Point(4, 655);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(797, 25);
            this.bottomBar.Stretch = true;
            this.bottomBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bottomBar.TabIndex = 7;
            this.bottomBar.TabStop = false;
            this.bottomBar.Text = "barStatus";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(203, 6);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(0, 0);
            this.lblTenNguoiDung.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNguoiDung.Location = new System.Drawing.Point(0, 6);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(179, 18);
            this.lblNguoiDung.TabIndex = 0;
            this.lblNguoiDung.Text = "Người dùng đang đăng nhập:";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.ctxMenuMain.SetContextMenuEx(this.tabStrip, this.btnMenuMain);
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Location = new System.Drawing.Point(4, 185);
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip.Size = new System.Drawing.Size(797, 32);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip.TabIndex = 1;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // mdiClient
            // 
            this.mdiClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.mdiClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mdiClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient.Location = new System.Drawing.Point(4, 217);
            this.mdiClient.Name = "mdiClient";
            this.mdiClient.Size = new System.Drawing.Size(797, 438);
            this.mdiClient.TabIndex = 2;
            this.mdiClient.Click += new System.EventHandler(this.mdiClient_Click);
            // 
            // ctxMenuMain
            // 
            this.ctxMenuMain.AntiAlias = true;
            this.ctxMenuMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenuMain});
            this.ctxMenuMain.Location = new System.Drawing.Point(508, 329);
            this.ctxMenuMain.Name = "ctxMenuMain";
            this.ctxMenuMain.Size = new System.Drawing.Size(105, 29);
            this.ctxMenuMain.Stretch = true;
            this.ctxMenuMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.TabIndex = 8;
            this.ctxMenuMain.TabStop = false;
            this.ctxMenuMain.Text = "ctxMenu";
            // 
            // btnMenuMain
            // 
            this.btnMenuMain.AutoExpandOnClick = true;
            this.btnMenuMain.ImagePaddingHorizontal = 8;
            this.btnMenuMain.Name = "btnMenuMain";
            this.btnMenuMain.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuMain.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhapContext,
            this.btnDangXuatContext,
            this.btnDoiMatKhauContext,
            this.btnThoatContext});
            this.btnMenuMain.Text = "Menu";
            // 
            // btnDangNhapContext
            // 
            this.btnDangNhapContext.Image = global::QLHocSinhTHPT.Properties.Resources.dangnhapcontext;
            this.btnDangNhapContext.ImagePaddingHorizontal = 8;
            this.btnDangNhapContext.Name = "btnDangNhapContext";
            this.btnDangNhapContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.btnDangNhapContext.Text = "Đăng nhập";
            this.btnDangNhapContext.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuatContext
            // 
            this.btnDangXuatContext.Image = global::QLHocSinhTHPT.Properties.Resources.dangxuatcontext;
            this.btnDangXuatContext.ImagePaddingHorizontal = 8;
            this.btnDangXuatContext.Name = "btnDangXuatContext";
            this.btnDangXuatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btnDangXuatContext.Text = "Đăng xuất hệ thống";
            this.btnDangXuatContext.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhauContext
            // 
            this.btnDoiMatKhauContext.ImagePaddingHorizontal = 8;
            this.btnDoiMatKhauContext.Name = "btnDoiMatKhauContext";
            // 
            // btnThoatContext
            // 
            this.btnThoatContext.Image = global::QLHocSinhTHPT.Properties.Resources.exit;
            this.btnThoatContext.ImagePaddingHorizontal = 8;
            this.btnThoatContext.Name = "btnThoatContext";
            this.btnThoatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnThoatContext.Text = "Thoát chương trình";
            this.btnThoatContext.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLHocSinhTHPT";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLHocSinhTHPT.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "QLHocSinhTHPT.chm";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 682);
            this.Controls.Add(this.ctxMenuMain);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.mdiClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelQuanLy.ResumeLayout(false);
            this.ribbonPanelQuyDinh.ResumeLayout(false);
            this.ribbonPanelTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.bottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).EndInit();
            this.ResumeLayout(false);

        }
        
        #endregion

        #region Components
        private System.Windows.Forms.MdiClient mdiClient;
        private System.Windows.Forms.SaveFileDialog backupDialog;
        private System.Windows.Forms.OpenFileDialog restoreDialog;
        private System.Windows.Forms.HelpProvider helpProvider;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuyDinh;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuanLy;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuyDinh;
        private DevComponents.DotNetBar.RibbonBar ribbonBarLop;
        private DevComponents.DotNetBar.ButtonItem btnLopHoc;
        private DevComponents.DotNetBar.RibbonBar ribbonBarQuyDinh;
        private DevComponents.DotNetBar.ButtonItem btnDoTuoi;
        private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup;
        private DevComponents.DotNetBar.Bar bottomBar;
        private DevComponents.DotNetBar.RibbonBar ribbonBarHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnHocSinh;
        private DevComponents.DotNetBar.ItemContainer itemContainerDanTocTonGiao;
        private DevComponents.DotNetBar.RibbonBar ribbonBarGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnPhanCong;
        private DevComponents.DotNetBar.ButtonItem btnSiSo;
        private DevComponents.DotNetBar.ButtonItem btnThangDiem;
        private DevComponents.DotNetBar.ButtonItem btnTruong;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.LabelX lblNguoiDung;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnDangNhapContext;
        private DevComponents.DotNetBar.ButtonItem btnDangXuatContext;
        private DevComponents.DotNetBar.ButtonItem btnDoiMatKhauContext;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelTraCuu;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabTraCuu;
        private DevComponents.DotNetBar.RibbonBar ribbonBarTraCuu;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemHS;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemGV;
        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnThoatContext;
        #endregion
    }
}