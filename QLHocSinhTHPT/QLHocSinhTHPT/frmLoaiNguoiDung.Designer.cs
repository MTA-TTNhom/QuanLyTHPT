namespace QLHocSinhTHPT
{
    partial class frmLoaiNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dGVLoaiNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoaiNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dGVLoaiNguoiDung);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(479, 391);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách loại người dùng";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(175, 201);
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
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::QLHocSinhTHPT.Properties.Resources.add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
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
            // dGVLoaiNguoiDung
            // 
            this.dGVLoaiNguoiDung.AllowUserToAddRows = false;
            this.dGVLoaiNguoiDung.AllowUserToResizeColumns = false;
            this.dGVLoaiNguoiDung.AllowUserToResizeRows = false;
            this.dGVLoaiNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVLoaiNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoai,
            this.colTenLoaiND});
            this.ctxMenu.SetContextMenuEx(this.dGVLoaiNguoiDung, this.btnMenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVLoaiNguoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVLoaiNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLoaiNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVLoaiNguoiDung.Location = new System.Drawing.Point(4, 19);
            this.dGVLoaiNguoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVLoaiNguoiDung.Name = "dGVLoaiNguoiDung";
            this.dGVLoaiNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVLoaiNguoiDung.Size = new System.Drawing.Size(471, 368);
            this.dGVLoaiNguoiDung.TabIndex = 3;
            this.dGVLoaiNguoiDung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVLoaiNguoiDung_DataError);
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.MaxInputLength = 6;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenLoaiND
            // 
            this.colTenLoaiND.DataPropertyName = "TenLoaiND";
            this.colTenLoaiND.HeaderText = "Tên loại người dùng";
            this.colTenLoaiND.MaxInputLength = 30;
            this.colTenLoaiND.Name = "colTenLoaiND";
            this.colTenLoaiND.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenLoaiND.Width = 210;
            // 
            // frmLoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 391);
            this.ctxMenu.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoaiNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI NGƯỜI DÙNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiNguoiDung_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoaiNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVLoaiNguoiDung;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiND;
        #endregion
    }
}