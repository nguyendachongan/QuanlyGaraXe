using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class PhieuThuBLL
    {
        PhieuThuDAL tdal = new PhieuThuDAL();
        public List<ePhieuThu> getAllPhieuThu()
        {
            List<ePhieuThu> listet = new List<ePhieuThu>();
            List<Phieu_thu> listt = new List<Phieu_thu>();
            listt = tdal.getAllPT();
            foreach (Phieu_thu t in listt)
            {
                ePhieuThu et = new ePhieuThu();
                et.HoTen = t.hoTen;
                et.NgayPH = t.ngayPH;
                et.SoHD = t.soHD;
                et.SoPhieu = t.soPH;
                et.SoTienThu =Convert.ToDouble(t.soTienThu);
                listet.Add(et);
            }
            return listet;
        }

        public ePhieuThu getTho(string ma)
        {
            ePhieuThu et = new ePhieuThu();
            Phieu_thu t = new Phieu_thu();
            t = tdal.getPT(ma);
            et.HoTen = t.hoTen;
            et.NgayPH = t.ngayPH;
            et.SoHD = t.soHD;
            et.SoPhieu = t.soPH;
            et.SoTienThu = Convert.ToDouble(t.soTienThu);
            return et;
        }

        public bool themPT(ePhieuThu et)
        {
            Phieu_thu t = new Phieu_thu();
            t.hoTen= et.HoTen;
            t.ngayPH=et.NgayPH;
            t.soHD=et.SoHD;
            t.soPH=et.SoPhieu;
            t.soTienThu=Convert.ToDecimal(et.SoTienThu);
            return tdal.themPT(t);
        }

        public bool xoaPT(string ma)
        {
            return tdal.xoaPT(ma);
        }

        public bool suaPT(ePhieuThu et)
        {
            Phieu_thu t = new Phieu_thu();
            t.hoTen = et.HoTen;
            t.ngayPH = et.NgayPH;
            t.soHD = et.SoHD;
            t.soPH = et.SoPhieu;
            t.soTienThu = Convert.ToDecimal(et.SoTienThu);
            return tdal.suaPT(t);

        }
    }
}
