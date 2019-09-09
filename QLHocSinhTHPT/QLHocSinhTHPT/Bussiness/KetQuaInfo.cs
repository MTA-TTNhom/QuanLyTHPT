using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class KetQuaInfo
    {
        public KetQuaInfo()
        {

        }

        private String m_MaKetQua;
        public String MaKetQua
        {
            get { return m_MaKetQua; }
            set { m_MaKetQua = value; }
        }

        private String m_TenKetQua;
        public String TenKetQua
        {
            get { return m_TenKetQua; }
            set { m_TenKetQua = value; }
        }
    }
}
