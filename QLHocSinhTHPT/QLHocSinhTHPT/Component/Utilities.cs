using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLHocSinhTHPT.Bussiness;
//using QLHocSinhTHPT.Reports;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;


namespace QLHocSinhTHPT.Component
{
    #region Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    #endregion

    #region QuyDinh
    public class QuyDinh
    {
        public static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }

        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }
    }
