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

        #region BindingNavigatorItems

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["colHoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                KiemTraTruocKhiLuu("colHoTen") == true &&
                KiemTraTruocKhiLuu("colNoiSinh") == true &&
                KiemTraTruocKhiLuu("colMaDanToc") == true &&
                KiemTraTruocKhiLuu("colMaTonGiao") == true &&
                KiemTraTruocKhiLuu("colHoTenCha") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepCha") == true &&
                KiemTraTruocKhiLuu("colHoTenMe") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepMe") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true)
                {
                    m_HocSinhCtrl.LuuHocSinh();
                }
            }
        }
        #endregion
    }
}
