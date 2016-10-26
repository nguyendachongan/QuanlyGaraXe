using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class CongViecBLL
    {
        CVDAL cvdal = new CVDAL();

        public List<eCV> getAllCV()
        {
            List<eCV> listecv = new List<eCV>();
            List<Cong_Viec> listcv = new List<Cong_Viec>();
            listcv = cvdal.getAllCV();
            foreach (Cong_Viec t in listcv)
            {
                eCV ehd = new eCV();
                ehd.NoidungCV = t.NOIDUNGCV;
                ehd.MaCV = t.MACV;
                listecv.Add(ehd);
            }
            return listecv;
        }

        public eCV getCV(string ma)
        {
            eCV ehd = new eCV();
            Cong_Viec t = new Cong_Viec();
            t = cvdal.getCV(ma);
            ehd.NoidungCV = t.MACV;
            ehd.MaCV = t.MACV;
            return ehd;
        }

        public bool themCV(eCV ehd)
        {
            Cong_Viec t = new Cong_Viec();
            t.NOIDUNGCV = ehd.NoidungCV;
            t.MACV = ehd.MaCV;
            return cvdal.themCV(t);
        }

        public bool xoaChiTietHD(string ma)
        {
            return cvdal.xoaCV(ma);
        }

        public bool suaHD(eCV ehd)
        {
            Cong_Viec t = new Cong_Viec();
            t.NOIDUNGCV = ehd.NoidungCV;
            t.MACV= ehd.MaCV;
            return cvdal.suaCV(t);

        }
    }
}
