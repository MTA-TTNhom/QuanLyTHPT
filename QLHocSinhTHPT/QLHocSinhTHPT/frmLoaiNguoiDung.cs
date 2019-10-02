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
    public partial class frmLoaiNguoiDung : Office2007Form
    {
        #region Fields
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh             quyDinh             = new QuyDinh();
        #endregion

        #region Constructor
        public frmLoaiNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThi(dGVLoaiNguoiDung);
        }
        #endregion

        #region BindingNavigatorItems
       

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVLoaiNguoiDung.Rows)
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

        
        #endregion

        #region DataError event
        private void dGVLoaiNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}
