using System;
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