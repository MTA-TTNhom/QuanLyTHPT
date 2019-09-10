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
        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
        }

        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    #endregion
    #region ThamSo
    public static class ThamSo
    {
        #region Fields
        public static frmAbout m_FrmAbout = null;
        public static frmConnection m_FrmConnection = null;
        public static frmGiaoVien m_FrmGiaoVien = null;
        public static frmHocSinh m_FrmHocSinh = null;
        public static frmLop m_FrmLop = null;
        public static frmMain m_FrmMain = null;
        public static frmPhanCong m_FrmPhanCong = null;
        public static frmLoaiNguoiDung m_FrmLoaiNguoiDung = null;
        public static frmTimKiemGV m_TimKiemGV = null;
        public static frmTimKiemHS m_TimKiemHS = null;
        public static frmQuyDinh m_FrmQuyDinh = null;
        //public static frptDanhSachGiaoVien      m_FrmDSGiaoVien         = null;
        //public static frptDanhSachHocSinh       m_FrmDSHocSinh          = null;
        //public static frptDanhSachLopHoc        m_FrmDSLopHoc           = null;
        //public static frptKetQuaCaNam_Lop       m_FrmKetQuaCaNam_Lop    = null;
        //public static frptKetQuaCaNam_MonHoc    m_FrmKetQuaCaNam_MonHoc = null;
        //public static frptKetQuaHocKy_Lop       m_FrmKetQuaHocKy_Lop    = null;
        //public static frptKetQuaHocKy_MonHoc    m_FrmKetQuaHocKy_MonHoc = null;
        #endregion

        #region Menu quan ly
        public static void ShowFormLopHoc()
        {
            if (m_FrmLop == null || m_FrmLop.IsDisposed)
            {
                m_FrmLop = new frmLop();
                m_FrmLop.MdiParent = frmMain.ActiveForm;
                m_FrmLop.Show();
            }
            else
                m_FrmLop.Activate();
        }

        public static void ShowFormKhoiLop()
        {

        }

        public static void ShowFormHocKy()
        {

        }

        public static void ShowFormNamHoc()
        {

        }

        public static void ShowFormMonHoc()
        {

        }

        public static void ShowFormLoaiDiem()
        {

        }

        public static void ShowFormNhapDiemRieng()
        {

        }

        public static void ShowFormNhapDiemChung()
        {

        }

        public static void ShowFormXemDiem()
        {

        }

        public static void ShowFormKetQua()
        {
        }

        public static void ShowFormHocLuc()
        {
        }

        public static void ShowFormHanhKiem()
        {

        }
    }
}
