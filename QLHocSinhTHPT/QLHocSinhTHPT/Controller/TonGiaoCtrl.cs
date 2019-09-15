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

            #region Hien thi ComboBox trong DataGridView
            public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
            {
                cmbColumn.DataSource = m_TonGiaoData.LayDsTonGiao();
                cmbColumn.DisplayMember = "TenTonGiao";
                cmbColumn.ValueMember = "MaTonGiao";
                cmbColumn.DataPropertyName = "MaTonGiao";
                cmbColumn.HeaderText = "Tôn giáo";
            }
            #endregion

            #region Do du lieu vao DataGridView
            public void HienThi(DataGridViewX dGV, BindingNavigator bN)
            {
                BindingSource bS = new BindingSource();

                bS.DataSource = m_TonGiaoData.LayDsTonGiao();
                bN.BindingSource = bS;
                dGV.DataSource = bS;
            }
            #endregion



            #region Do du lieu vao DataGridView
            public void HienThi(DataGridViewX dGV, BindingNavigator bN)
            {
                BindingSource bS = new BindingSource();

                bS.DataSource = m_TonGiaoData.LayDsTonGiao();
                bN.BindingSource = bS;
                dGV.DataSource = bS;
            }
            #endregion



        }





    }
