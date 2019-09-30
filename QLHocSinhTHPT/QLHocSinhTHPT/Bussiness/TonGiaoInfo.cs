using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class TonGiaoInfo
    {
       
        public String MaTonGiao
        {
            get { return m_MaTonGiao; }
            set { m_MaTonGiao = value; }
        }


       
        public String TenTonGiao
        {
            get { return m_TenTonGiao; }
            set { m_TenTonGiao = value; }
        }
        private String m_TenTonGiao;
        public TonGiaoInfo()
        {

        }

        private String m_MaTonGiao;
    }
}
