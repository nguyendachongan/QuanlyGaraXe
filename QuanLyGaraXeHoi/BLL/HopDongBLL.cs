using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class HopDongBLL
    {
        HopDongDAL hddal = new HopDongDAL();
        
        public List<eHopDong> getAllHopDong()
        {
            List<eHopDong> listehd = new List<eHopDong>();
            List<Hop_Dong> listhd = new List<Hop_Dong>();
            listhd = hddal.getAllHD();
            foreach (Hop_Dong t in listhd)
            {
                eHopDong ehd = new eHopDong();
                ehd.SoHD = t.soHD;
                ehd.MaKH = t.maKH;
                ehd.Ngayngthu = t.ng_NgThu;
                ehd.TenKH = t.tenKH;
                ehd.TriGiaHD =Convert.ToDouble(t.triGiaHD);
                ehd.Diachi = t.diaChi;
                ehd.NgayHD = t.ngayHD;
                ehd.Ngaygiao = t.ngayHD;
                ehd.SoXe = ehd.SoXe;
                listehd.Add(ehd);
            }
            return listehd;
        }

        public eHopDong getTho(string ma)
        {
            eHopDong ehd = new eHopDong();
            Hop_Dong t = new Hop_Dong();
            t = hddal.getHD(ma);
            ehd.SoHD = t.soHD;
            ehd.MaKH = t.maKH;
            ehd.Ngayngthu = t.ng_NgThu;
            ehd.TenKH = t.tenKH;
            ehd.TriGiaHD = Convert.ToDouble(t.triGiaHD);
            ehd.Diachi = t.diaChi;
            ehd.NgayHD = t.ngayHD;
            ehd.Ngaygiao = t.ngayHD;
            ehd.SoXe = t.soXe;
            return ehd;
        }

        public bool themHD(eHopDong ehd)
        {
            Hop_Dong t = new Hop_Dong();
            t.soHD = ehd.SoHD;
            t.maKH=ehd.MaKH;
            t.ng_NgThu=ehd.Ngayngthu;
            t.tenKH=ehd.TenKH ;
            t.triGiaHD=Convert.ToDecimal(ehd.TriGiaHD) ;
            t.diaChi=ehd.Diachi ;
            t.ngayHD=ehd.NgayHD;
            t.ngayHD=ehd.Ngaygiao ;
            t.soXe = ehd.SoXe;
            return hddal.themHD(t);
        }

        public bool xoaHD(string ma)
        {
            return hddal.xoaHD(ma);
        }

        public bool suaHD(eHopDong ehd)
        {
            Hop_Dong t = new Hop_Dong();
            t.soHD = ehd.SoHD;
            t.maKH = ehd.MaKH;
            t.ng_NgThu = ehd.Ngayngthu;
            t.tenKH = ehd.TenKH;
            t.triGiaHD = Convert.ToDecimal(ehd.TriGiaHD);
            t.diaChi = ehd.Diachi;
            t.ngayHD = ehd.NgayHD;
            t.ngayHD = ehd.Ngaygiao;
            t.soXe = ehd.SoXe;
            return hddal.suaHD(t);

        }
    }
}
