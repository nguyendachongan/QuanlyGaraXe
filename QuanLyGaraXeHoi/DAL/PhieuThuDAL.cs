using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuDAL
    {
        QLGRXHDataContext db = new QLGRXHDataContext();
        public List<Phieu_thu> getAllPT()
        {
            var t = (from a in db.Phieu_thus select a).ToList();
            return t;
        }

        public Phieu_thu getPT(string ma)
        {
            var t = (from a in db.Phieu_thus where a.soPH == ma select a).SingleOrDefault();
            return t;
        }

        public bool themPT(Phieu_thu th)
        {

            var t = (from a in db.Phieu_thus where a.soPH == th.soPH select a).SingleOrDefault();
            if (t == null)
            {
                db.Phieu_thus.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaPT(string ma)
        {

            var t = (from a in db.Phieu_thus where a.soPH == ma select a).SingleOrDefault();
            if (t != null)
            {
                db.Phieu_thus.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaPT(Phieu_thu th)
        {

            var t = (from a in db.Phieu_thus where a.soPH == th.soPH select a).SingleOrDefault();
            if (t != null)
            {
                t.soPH = th.soPH;
                t.ngayPH = th.ngayPH;
                t.soHD = th.soHD;
                t.hoTen = th.hoTen;
                t.soTienThu = th.soTienThu;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
