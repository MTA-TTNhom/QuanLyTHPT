using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class LoaiDiemInfo
    {
        public LoaiDiemInfo()
        {

        }

        private String m_MaLoai;
        public String MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }

        private String m_TenLoai;
        public String TenLoai
        {
            get { return m_TenLoai; }
            set { m_TenLoai = value; }
        }

        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
    }
}
