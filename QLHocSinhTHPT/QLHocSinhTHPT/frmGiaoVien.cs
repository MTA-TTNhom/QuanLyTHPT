﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using QLHocSinhTHPT.Component;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmGiaoVien : Office2007Form
    {
        #region Fields
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        QuyDinh         quyDinh         = new QuyDinh();
        #endregion

        #region Constructor
        public frmGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbMonHoc);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);

            m_GiaoVienCtrl.HienThi(dGVGiaoVien);
            
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            
        }
		
		     private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
		
        private void label1_Click(object sender, EventArgs e)
        {
            /*indexdsa
             * cho nay de check login 
             * dsdsa*/
        }
		            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*indexdsa
             * cho nay de check login 
             * dsdsa*/
        }
		            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControl.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new LOGIN());
            //Application.Run(new Form1());
        }
		
        ///showfromChild
        ///
        private void showFormChild(Form f)
        {
            if (!isOpened(f))
            {
                f.MdiParent = this;
                f.Show();
            }
        }
        private bool isOpened(Form f)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (f.Name == item.Name)
                    {
                        xtmm.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                }
            }
            return isOpened;
        }
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLogin.Enabled = false;
            LOGIN login = new LOGIN();
            login.ShowDialog();
            this.Hide();
        }
        private void btnAcountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AcountInfo info = new AcountInfo();
            info.init(idEmployees, passWord);
            showFormChild(info);
        }

   er_Store();
            showFormChild(info);
        }

        private void btnSupplier_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Supplier_Store info = new Supplier_Store();
            showFormChild(info);
        }

        private void btnInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inventory info = new Inventory();
            showFormChild(info);
        }

        private void btnStatistical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác minh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnList_ReceiptVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListReceipt_Vou info = new ListReceipt_Vou();
            showFormChild(info);
        }

        private void btnList_IssueVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListIssue_Vou info = new ListIssue_Vou();
            showFormChild(info);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin giáo viên " + row.Cells["colTenGiaoVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            
        }


        #endregion

    }
}