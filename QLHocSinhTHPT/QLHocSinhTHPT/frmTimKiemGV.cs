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
    public partial class frmTimKiemGV : Form
    {
        #region Fields
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public frmTimKiemGV()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmTimKiemGV_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbCMon);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tìm kiếm giáo viên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txtHoTen, cmbTheoDChi, txtDiaChi, cmbTheoCMon, cmbCMon, dGVKetQuaTimKiem);

            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có giáo viên cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
