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
    public partial class frmPhanCong : Office2007Form
    {
        #region Fields
        PhanCongCtrl    m_PhanCongCtrl  = new PhanCongCtrl();
        NamHocCtrl      m_NamHocCtrl    = new NamHocCtrl();
        LopCtrl         m_LopCtrl       = new LopCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public frmPhanCong()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_LopCtrl.HienThiComboBox(cmbLop);
            m_MonHocCtrl.HienThiComboBox(cmbMonHoc);
            m_GiaoVienCtrl.HienThiComboBox(cmbGiaoVien);

            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(colMaLop);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(colMaMonHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);

            m_PhanCongCtrl.HienThi(dGVPhanCong, txtSTT, cmbNamHoc, cmbLop, cmbMonHoc, cmbGiaoVien);
        }
        #endregion

        #region BindingNavigatorItems
        

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVPhanCong.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaNamHoc")   == true &&
                KiemTraTruocKhiLuu("colMaLop")      == true &&
                KiemTraTruocKhiLuu("colMaMonHoc")   == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true)
            {
                m_PhanCongCtrl.LuuPhanCong();
            }
        }
        #endregion

        #region DataError Event
        private void dGVPhanCong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm giáo viên trong bảng phân công
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemPhanCong();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemPhanCong();
        }

        void TimKiemPhanCong()
        {
            if (chkTimTheoTenLop.Checked == true)
            {
                m_PhanCongCtrl.TimTheoTenLop(txtTimKiem.Text);
            }
            else
            {
                m_PhanCongCtrl.TimTheoTenGV(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event
        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLopHoc();
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(colMaLop);
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(colMaMonHoc);
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);
        }

        
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }
        #endregion
    }
}