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
    public partial class frmHocSinh : Form
    {
        #region Fields
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NgheNghiepCtrl m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl m_NgheNghiepMeCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cmbDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cmbTonGiao);
            m_NgheNghiepChaCtrl.HienThiComboBox(cmbNgheNghiepCha);
            m_NgheNghiepMeCtrl.HienThiComboBox(cmbNgheNghiepMe);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);

            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }
        #endregion
    }
}
