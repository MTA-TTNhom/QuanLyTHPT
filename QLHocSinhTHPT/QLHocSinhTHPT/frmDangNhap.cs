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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            #region Constructor
            public frmDangNhap()
            {
                InitializeComponent();
            }
            #endregion

            #region Click event
            private void btnDangNhap_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
            }

            private void btnHuyBo_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            #endregion

            #region Key event
            private void txtPassword_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            #endregion

            private void lblPassword_Click(object sender, EventArgs e)
            {

            }
        }
}
