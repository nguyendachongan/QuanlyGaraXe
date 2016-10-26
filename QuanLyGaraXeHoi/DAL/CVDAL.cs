using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CVDAL
    {
        QLGRXHDataContext db = new QLGRXHDataContext();
        public List<Cong_Viec> getAllCV()
        {
            var t = (from a in db.Cong_Viecs select a).ToList();
            return t;
        }

        public Cong_Viec getCV(string ma)
        {
            var t = (from a in db.Cong_Viecs where a.MACV == ma select a).SingleOrDefault();
            return t;
        }

        public bool themCV(Cong_Viec th)
        {

            var t = (from a in db.Cong_Viecs where a.MACV == th.MACV select a).SingleOrDefault();
            if (t == null)
            {
                db.Cong_Viecs.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaCV(string ma)
        {

            var t = (from a in db.Cong_Viecs where a.MACV == ma select a).SingleOrDefault();
            if (t != null)
            {
                db.Cong_Viecs.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaCV(Cong_Viec th)
        {

            var t = (from a in db.Cong_Viecs where a.MACV == th.MACV select a).SingleOrDefault();
            if (t != null)
            {
                t.MACV = th.MACV;
                t.NOIDUNGCV = th.NOIDUNGCV;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
