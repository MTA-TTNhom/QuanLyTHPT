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
    public partial class frmLop : Form
    {
        #region Fields
        LopCtrl m_LopCtrl = new LopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_GiaoVienCtrl.HienThiComboBox(cmbGiaoVien);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);

            m_LopCtrl.HienThi(dGVLop, txtMaLop, txtTenLop, cmbKhoiLop, cmbNamHoc, iniSiSo, cmbGiaoVien);
        }
        #endregion



    }
}
