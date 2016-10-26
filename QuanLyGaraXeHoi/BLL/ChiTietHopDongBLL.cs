using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class ChiTietHopDongBLL
    {
        ChiTietHopDongDAL hddal = new ChiTietHopDongDAL();

        public List<eChiTietHopDong> getAllChiTietHD(string ma)
        {
            List<eChiTietHopDong> listecthd = new List<eChiTietHopDong>();
            List<Chitiet_HD> listcthd = new List<Chitiet_HD>();
            listcthd = hddal.getAllCTHD(ma);
            foreach (Chitiet_HD t in listcthd)
            {
                eChiTietHopDong ehd = new eChiTietHopDong();
                ehd.SoHD = t.soHD;
                ehd.KhoanTho =Convert.ToDouble(t.khoanTho);
                ehd.MaCV = t.maCV;
                ehd.TriGiaCV =Convert.ToDouble(t.triGia_CV);
                ehd.MaTho = t.maTho;
                listecthd.Add(ehd);
            }
            return listecthd;
        }

        public eChiTietHopDong getChiTietHD(string ma,string cv)
        {
            eChiTietHopDong ehd = new eChiTietHopDong();
            Chitiet_HD t = new Chitiet_HD();
            t = hddal.getCTHD(ma,cv);
            ehd.SoHD = t.soHD;
            ehd.KhoanTho = Convert.ToDouble(t.khoanTho);
            ehd.MaCV = t.maCV;
            ehd.TriGiaCV = Convert.ToDouble(t.triGia_CV);
            ehd.MaTho = t.maTho;
            return ehd;
        }

        public bool themChiTietHD(eChiTietHopDong ehd)
        {
            Chitiet_HD t = new Chitiet_HD();
            t.soHD = ehd.SoHD;
            t.maCV = ehd.MaCV;
            t.maTho = ehd.MaTho;
            t.triGia_CV =Convert.ToDecimal(ehd.TriGiaCV);
            t.khoanTho = Convert.ToDecimal(ehd.KhoanTho);
            return hddal.themCTHD(t);
        }

        public bool xoaChiTietHD(string ma,string cv)
        {
            return hddal.xoaCTHD(ma,cv);
        }

        public bool suaHD(eChiTietHopDong ehd)
        {
            Chitiet_HD t = new Chitiet_HD();
            t.soHD = ehd.SoHD;
            t.maCV = ehd.MaCV;
            t.maTho = ehd.MaTho;
            t.triGia_CV = Convert.ToDecimal(ehd.TriGiaCV);
            t.khoanTho = Convert.ToDecimal(ehd.KhoanTho);
            return hddal.suaCTHD(t);

        }
    }
}
