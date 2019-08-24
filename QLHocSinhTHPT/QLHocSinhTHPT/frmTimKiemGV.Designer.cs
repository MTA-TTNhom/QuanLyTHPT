namespace QLHocSinhTHPT
{
    partial class frmTimKiemGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemGV));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVKetQuaTimKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmbCMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTheoCMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col04 = new DevComponents.Editors.ComboItem();
            this.col05 = new DevComponents.Editors.ComboItem();
            this.col06 = new DevComponents.Editors.ComboItem();
            this.cmbTheoDChi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col01 = new DevComponents.Editors.ComboItem();
            this.col02 = new DevComponents.Editors.ComboItem();
            this.col03 = new DevComponents.Editors.ComboItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetQuaTimKiem)).BeginInit();
            this.navPaneLeft.SuspendLayout();
            this.navPanelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVKetQuaTimKiem);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(247, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(838, 490);
            this.groupBoxDanhSach.TabIndex = 2;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Kết quả tìm kiếm";

        }

        #endregion
    }
}