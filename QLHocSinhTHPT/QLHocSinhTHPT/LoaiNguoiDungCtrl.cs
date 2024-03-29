﻿using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{


    public class LoaiNguoiDungCtrl
    {


        LoaiNguoiDungData m_LoaiNguoiDungData = new LoaiNguoiDungData();

        #region Hien thi ComboBox


        public void HienThiComboBox(ComboBoxEx comboBox)
        {

            comboBox.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();

            comboBox.DisplayMember = "TenLoaiND";

            comboBox.ValueMember = "MaLoai";


        }


        #endregion



        #region Hien thi ComboBox trong DataGridView


        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {

            cmbColumn.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();

            cmbColumn.DisplayMember = "TenLoaiND";

            cmbColumn.ValueMember = "MaLoai";

            cmbColumn.DataPropertyName = "MaLoai";


            cmbColumn.HeaderText = "Loại người dùng";
        }


        #endregion


        #region Do du lieu vao DataGridView

        public void HienThi(DataGridViewX dGV)
        {

            BindingSource bS = new BindingSource();


            bS.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();


            dGV.DataSource = bS;


        }
        #endregion



        #region Them moi


        public DataRow ThemDongMoi()

        {


            return m_LoaiNguoiDungData.ThemDongMoi();


        }



        public void ThemLoaiNguoiDung(DataRow m_Row)
        {


            m_LoaiNguoiDungData.ThemLoaiNguoiDung(m_Row);


        }


        #endregion

        #region Luu du lieu


        public bool LuuLoaiNguoiDung()
        {


            return m_LoaiNguoiDungData.LuuLoaiNguoiDung();


        }

        #endregion

    }



}
