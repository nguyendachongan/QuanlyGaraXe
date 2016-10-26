using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHopDongDAL
    {
        QLGRXHDataContext db = new QLGRXHDataContext();
        public List<Chitiet_HD> getAllCTHD(string ma)
        {
            var t = (from a in db.Chitiet_HDs where a.soHD==ma select a).ToList();
            return t;
        }

        public Chitiet_HD getCTHD(string hd,string cv)
        {
            var t = (from a in db.Chitiet_HDs where a.soHD == hd &&a.maCV==cv select a).SingleOrDefault();
            return t;
        }

        public bool themCTHD(Chitiet_HD th)
        {

            var t = (from a in db.Chitiet_HDs where a.maCV == th.maCV && a.soHD==th.soHD select a).SingleOrDefault();
            if (t == null)
            {
                db.Chitiet_HDs.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaCTHD(string hd,string cv)
        {

            var t = (from a in db.Chitiet_HDs where a.soHD == hd&&a.maCV==cv select a).SingleOrDefault();
            if (t != null)
            {
                db.Chitiet_HDs.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaCTHD(Chitiet_HD th)
        {

            var t = (from a in db.Chitiet_HDs where a.maCV == th.maCV && a.soHD == th.soHD select a).SingleOrDefault();
            if (t != null)
            {
                t.maCV = th.maCV;
                t.soHD = th.soHD;
                t.khoanTho = th.khoanTho;
                t.maTho = th.maTho;
                t.triGia_CV = th.triGia_CV;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
