using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocSinhTHPT.Controller
{
    class TonGiaoCtrl
    {


        public class TonGiaoCtrl
        {
            TonGiaoData m_TonGiaoData = new TonGiaoData();

            #region Hien thi ComboBox
            public void HienThiComboBox(ComboBoxEx comboBox)
            {
                comboBox.DataSource = m_TonGiaoData.LayDsTonGiao();
                comboBox.DisplayMember = "TenTonGiao";
                comboBox.ValueMember = "MaTonGiao";
            }
            #endregion


        }





    }
