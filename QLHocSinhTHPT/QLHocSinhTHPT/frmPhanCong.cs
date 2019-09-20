using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocSinhTHPT
{
    public partial class frmPhanCong : Form
    {
        #region Fields
        PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
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
            if (KiemTraTruocKhiLuu("colMaNamHoc") == true &&
                KiemTraTruocKhiLuu("colMaLop") == true &&
                KiemTraTruocKhiLuu("colMaMonHoc") == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true)
            {
                m_PhanCongCtrl.LuuPhanCong();
            }
        }
        #endregion
        public frmPhanCong()
        {
            InitializeComponent();
        }
    }
}
