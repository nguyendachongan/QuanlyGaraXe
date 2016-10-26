using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HopDongDAL
    {
        QLGRXHDataContext db = new QLGRXHDataContext();
        public List<Hop_Dong> getAllHD()
        {
            var t = (from a in db.Hop_Dongs select a).ToList();
            return t;
        }

        public Hop_Dong getHD(string ma)
        {
            var t = (from a in db.Hop_Dongs where a.soHD == ma select a).SingleOrDefault();
            return t;
        }

        public bool themHD(Hop_Dong th)
        {

            var t = (from a in db.Hop_Dongs where a.soHD == th.soHD select a).SingleOrDefault();
            if (t == null)
            {
                db.Hop_Dongs.InsertOnSubmit(t);
                //db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaHD(string ma)
        {

            var t = (from a in db.Hop_Dongs where a.soHD == ma select a).SingleOrDefault();
            if (t != null)
            {
                db.Hop_Dongs.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaHD(Hop_Dong th)
        {

            var t = (from a in db.Hop_Dongs where a.soHD == th.soHD select a).SingleOrDefault();
            if (t != null)
            {
                t.soHD = th.soHD;
                t.soXe = th.soXe;
                t.tenKH = th.tenKH;
                t.triGiaHD = th.triGiaHD;
                t.ng_NgThu = th.ng_NgThu;
                t.ng_Giao_DK = th.ng_Giao_DK;
                t.ngayHD = th.ngayHD;
                t.maKH = th.maKH;
                t.diaChi = th.diaChi;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
