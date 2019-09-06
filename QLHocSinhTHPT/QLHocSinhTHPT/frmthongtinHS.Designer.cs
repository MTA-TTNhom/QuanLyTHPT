namespace QLHocSinhTHPT
{
    partial class frmthongtinHS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dGVHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new QLHocSinhTHPT.Component.CalendarColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanToc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTonGiao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNNghiepCha = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNNghiepMe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.groupPanelGioiTinh = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ckbGTinhNam = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbGTinhNu = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNNMe = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNNCha = new DevComponents.DotNetBar.ButtonX();
            this.btnThemDanToc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTonGiao = new DevComponents.DotNetBar.ButtonX();
            this.label02 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.cmbNgheNghiepMe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNgheNghiepCha = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbDanToc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTonGiao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label03 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.txtHoTenMe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label07 = new System.Windows.Forms.Label();
            this.txtHoTenCha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label05 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGioiTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.label01 = new System.Windows.Forms.Label();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocSinh)).BeginInit();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.groupPanelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).BeginInit();
            this.navPanelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dGVHocSinh);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(260, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(732, 576);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách học sinh";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(332, 250);
            this.ctxMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(100, 29);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 4;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePaddingHorizontal = 8;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::QLHocSinhTHPT.Properties.Resources.refresh;
            this.btnRefesh.ImagePaddingHorizontal = 8;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh dách";
            this.btnRefesh.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLHocSinhTHPT.Properties.Resources.delete;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHocSinhTHPT.Properties.Resources.save;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QLHocSinhTHPT.Properties.Resources.exit;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // dGVHocSinh
            // 
            this.dGVHocSinh.AllowUserToAddRows = false;
            this.dGVHocSinh.AllowUserToResizeRows = false;
            this.dGVHocSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colMaDanToc,
            this.colMaTonGiao,
            this.colHoTenCha,
            this.colMaNNghiepCha,
            this.colHoTenMe,
            this.colMaNNghiepMe});
            this.ctxMenu.SetContextMenuEx(this.dGVHocSinh, this.btnMenu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVHocSinh.Location = new System.Drawing.Point(4, 62);
            this.dGVHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVHocSinh.Name = "dGVHocSinh";
            this.dGVHocSinh.Size = new System.Drawing.Size(724, 510);
            this.dGVHocSinh.TabIndex = 5;
            this.dGVHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHocSinh_CellClick);
            this.dGVHocSinh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVHocSinh_DataError);
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MaxInputLength = 6;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính nữ";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 85;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "NoiSinh";
            this.colNoiSinh.HeaderText = "Nơi sinh";
            this.colNoiSinh.MaxInputLength = 50;
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Width = 150;
            // 
            // colMaDanToc
            // 
            this.colMaDanToc.DataPropertyName = "MaDanToc";
            this.colMaDanToc.HeaderText = "Dân tộc";
            this.colMaDanToc.Name = "colMaDanToc";
            // 
            // colMaTonGiao
            // 
            this.colMaTonGiao.DataPropertyName = "MaTonGiao";
            this.colMaTonGiao.HeaderText = "Tôn giáo";
            this.colMaTonGiao.Name = "colMaTonGiao";
            // 
            // colHoTenCha
            // 
            this.colHoTenCha.DataPropertyName = "HoTenCha";
            this.colHoTenCha.HeaderText = "Họ tên cha";
            this.colHoTenCha.MaxInputLength = 30;
            this.colHoTenCha.Name = "colHoTenCha";
            this.colHoTenCha.Width = 150;
            // 
            // colMaNNghiepCha
            // 
            this.colMaNNghiepCha.DataPropertyName = "MaNNghiepCha";
            this.colMaNNghiepCha.HeaderText = "Nghề nghiệp cha";
            this.colMaNNghiepCha.Name = "colMaNNghiepCha";
            // 
            // colHoTenMe
            // 
            this.colHoTenMe.DataPropertyName = "HoTenMe";
            this.colHoTenMe.HeaderText = "Họ tên mẹ";
            this.colHoTenMe.MaxInputLength = 30;
            this.colHoTenMe.Name = "colHoTenMe";
            this.colHoTenMe.Width = 150;
            // 
            // colMaNNghiepMe
            // 
            this.colMaNNghiepMe.DataPropertyName = "MaNNghiepMe";
            this.colMaNNghiepMe.HeaderText = "Nghề nghiệp mẹ";
            this.colMaNNghiepMe.Name = "colMaNNghiepMe";
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.Controls.Add(this.navPanelTimKiem);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNhapDuLieu,
            this.buttonItemTimKiem});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 68;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(260, 576);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 0;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(258, 30);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Nhập liệu thông tin";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.AutoScroll = true;
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.groupPanelGioiTinh);
            this.navPanelNhapDuLieu.Controls.Add(this.lblBuffer);
            this.navPanelNhapDuLieu.Controls.Add(this.dtpNgaySinh);
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNNMe);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNNCha);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemDanToc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemTonGiao);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.label04);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNgheNghiepMe);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNgheNghiepCha);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbDanToc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbTonGiao);
            this.navPanelNhapDuLieu.Controls.Add(this.label03);
            this.navPanelNhapDuLieu.Controls.Add(this.txtMaHocSinh);
            this.navPanelNhapDuLieu.Controls.Add(this.label12);
            this.navPanelNhapDuLieu.Controls.Add(this.label10);
            this.navPanelNhapDuLieu.Controls.Add(this.label08);
            this.navPanelNhapDuLieu.Controls.Add(this.label06);
            this.navPanelNhapDuLieu.Controls.Add(this.label11);
            this.navPanelNhapDuLieu.Controls.Add(this.label09);
            this.navPanelNhapDuLieu.Controls.Add(this.txtHoTenMe);
            this.navPanelNhapDuLieu.Controls.Add(this.label07);
            this.navPanelNhapDuLieu.Controls.Add(this.txtHoTenCha);
            this.navPanelNhapDuLieu.Controls.Add(this.label05);
            this.navPanelNhapDuLieu.Controls.Add(this.txtNoiSinh);
            this.navPanelNhapDuLieu.Controls.Add(this.txtTenHocSinh);
            this.navPanelNhapDuLieu.Controls.Add(this.txtGioiTinh);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 31);
            this.navPanelNhapDuLieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(258, 476);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // groupPanelGioiTinh
            // 
            this.groupPanelGioiTinh.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelGioiTinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNam);
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNu);
            this.groupPanelGioiTinh.Location = new System.Drawing.Point(15, 142);
            this.groupPanelGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanelGioiTinh.Name = "groupPanelGioiTinh";
            this.groupPanelGioiTinh.Size = new System.Drawing.Size(213, 30);
            // 
            // 
            // 
            this.groupPanelGioiTinh.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelGioiTinh.Style.BackColorGradientAngle = 90;
            this.groupPanelGioiTinh.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelGioiTinh.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderBottomWidth = 1;
            this.groupPanelGioiTinh.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelGioiTinh.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderLeftWidth = 1;
            this.groupPanelGioiTinh.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderRightWidth = 1;
            this.groupPanelGioiTinh.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderTopWidth = 1;
            this.groupPanelGioiTinh.Style.CornerDiameter = 4;
            this.groupPanelGioiTinh.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelGioiTinh.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelGioiTinh.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelGioiTinh.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelGioiTinh.TabIndex = 4;
            // 
            // ckbGTinhNam
            // 
            this.ckbGTinhNam.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNam.Location = new System.Drawing.Point(3, 0);
            this.ckbGTinhNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbGTinhNam.Name = "ckbGTinhNam";
            this.ckbGTinhNam.Size = new System.Drawing.Size(80, 22);
            this.ckbGTinhNam.TabIndex = 1;
            this.ckbGTinhNam.Text = "Nam";
            // 
            // ckbGTinhNu
            // 
            this.ckbGTinhNu.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ckbGTinhNu.Location = new System.Drawing.Point(96, 0);
            this.ckbGTinhNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbGTinhNu.Name = "ckbGTinhNu";
            this.ckbGTinhNu.Size = new System.Drawing.Size(80, 22);
            this.ckbGTinhNu.TabIndex = 2;
            this.ckbGTinhNu.Text = "Nữ";
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Enabled = false;
            this.lblBuffer.Location = new System.Drawing.Point(11, 650);
            this.lblBuffer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(0, 17);
            this.lblBuffer.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            // 
            // 
            // 
            this.dtpNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaySinh.ButtonDropDown.Visible = true;
            this.dtpNgaySinh.Location = new System.Drawing.Point(15, 197);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(133, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(13, 622);
            this.btnLuuVaoDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(213, 28);
            this.btnLuuVaoDS.TabIndex = 17;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // btnThemNNMe
            // 
            this.btnThemNNMe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNNMe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNNMe.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnThemNNMe.Location = new System.Drawing.Point(155, 585);
            this.btnThemNNMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNNMe.Name = "btnThemNNMe";
            this.btnThemNNMe.Size = new System.Drawing.Size(27, 25);
            this.btnThemNNMe.TabIndex = 16;
            this.btnThemNNMe.Click += new System.EventHandler(this.btnThemNNMe_Click);
            // 
            // btnThemNNCha
            // 
            this.btnThemNNCha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNNCha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNNCha.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnThemNNCha.Location = new System.Drawing.Point(155, 474);
            this.btnThemNNCha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNNCha.Name = "btnThemNNCha";
            this.btnThemNNCha.Size = new System.Drawing.Size(27, 25);
            this.btnThemNNCha.TabIndex = 13;
            this.btnThemNNCha.Click += new System.EventHandler(this.btnThemNNCha_Click);
            // 
            // btnThemDanToc
            // 
            this.btnThemDanToc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDanToc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDanToc.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnThemDanToc.Location = new System.Drawing.Point(155, 308);
            this.btnThemDanToc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemDanToc.Name = "btnThemDanToc";
            this.btnThemDanToc.Size = new System.Drawing.Size(27, 25);
            this.btnThemDanToc.TabIndex = 8;
            this.btnThemDanToc.Click += new System.EventHandler(this.btnThemDanToc_Click);
            // 
            // btnThemTonGiao
            // 
            this.btnThemTonGiao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTonGiao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTonGiao.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnThemTonGiao.Location = new System.Drawing.Point(155, 363);
            this.btnThemTonGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTonGiao.Name = "btnThemTonGiao";
            this.btnThemTonGiao.Size = new System.Drawing.Size(27, 25);
            this.btnThemTonGiao.TabIndex = 10;
            this.btnThemTonGiao.Click += new System.EventHandler(this.btnThemTonGiao_Click);
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(11, 12);
            this.label02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(88, 17);
            this.label02.TabIndex = 0;
            this.label02.Text = "Mã học sinh:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(11, 123);
            this.label04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(64, 17);
            this.label04.TabIndex = 0;
            this.label04.Text = "Giới tính:";
            // 
            // cmbNgheNghiepMe
            // 
            this.cmbNgheNghiepMe.DisplayMember = "Text";
            this.cmbNgheNghiepMe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgheNghiepMe.FormattingEnabled = true;
            this.cmbNgheNghiepMe.ItemHeight = 14;
            this.cmbNgheNghiepMe.Location = new System.Drawing.Point(15, 585);
            this.cmbNgheNghiepMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNgheNghiepMe.Name = "cmbNgheNghiepMe";
            this.cmbNgheNghiepMe.Size = new System.Drawing.Size(132, 20);
            this.cmbNgheNghiepMe.TabIndex = 15;
            // 
            // cmbNgheNghiepCha
            // 
            this.cmbNgheNghiepCha.DisplayMember = "Text";
            this.cmbNgheNghiepCha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgheNghiepCha.FormattingEnabled = true;
            this.cmbNgheNghiepCha.ItemHeight = 14;
            this.cmbNgheNghiepCha.Location = new System.Drawing.Point(15, 474);
            this.cmbNgheNghiepCha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNgheNghiepCha.Name = "cmbNgheNghiepCha";
            this.cmbNgheNghiepCha.Size = new System.Drawing.Size(132, 20);
            this.cmbNgheNghiepCha.TabIndex = 12;
            // 
            // cmbDanToc
            // 
            this.cmbDanToc.DisplayMember = "Text";
            this.cmbDanToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDanToc.FormattingEnabled = true;
            this.cmbDanToc.ItemHeight = 14;
            this.cmbDanToc.Location = new System.Drawing.Point(15, 308);
            this.cmbDanToc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(132, 20);
            this.cmbDanToc.TabIndex = 7;
            // 
            // cmbTonGiao
            // 
            this.cmbTonGiao.DisplayMember = "Text";
            this.cmbTonGiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTonGiao.FormattingEnabled = true;
            this.cmbTonGiao.ItemHeight = 14;
            this.cmbTonGiao.Location = new System.Drawing.Point(15, 363);
            this.cmbTonGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTonGiao.Name = "cmbTonGiao";
            this.cmbTonGiao.Size = new System.Drawing.Size(132, 20);
            this.cmbTonGiao.TabIndex = 9;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(11, 68);
            this.label03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(94, 17);
            this.label03.TabIndex = 0;
            this.label03.Text = "Tên học sinh:";
            // 
            // txtMaHocSinh
            // 
            // 
            // 
            // 
            this.txtMaHocSinh.Border.Class = "TextBoxBorder";
            this.txtMaHocSinh.Location = new System.Drawing.Point(15, 31);
            this.txtMaHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHocSinh.MaxLength = 6;
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(133, 22);
            this.txtMaHocSinh.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 566);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nghề nghiệp mẹ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 455);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nghề nghiệp cha:";
            // 
            // label08
            // 
            this.label08.AutoSize = true;
            this.label08.Location = new System.Drawing.Point(11, 345);
            this.label08.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(68, 17);
            this.label08.TabIndex = 0;
            this.label08.Text = "Tôn giáo:";
        }

        #endregion
    }
}