using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThoDAL
    {
        QLGRXHDataContext db = new QLGRXHDataContext();
        public List<Tho> getAllTho()
        {
            var t = (from a in db.Thos select a).ToList();
            return t;
        }

        public Tho getTho(string ma)
        {
            var t = (from a in db.Thos where a.maTho == ma select a).SingleOrDefault();
            return t;
        }

        public bool themTho(Tho th)
        {

            var t = (from a in db.Thos where a.maTho == th.maTho select a).SingleOrDefault();
            if (t == null)
            {
                db.Thos.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaTho(string ma)
        {

            var t = (from a in db.Thos where a.maTho == ma select a).SingleOrDefault();
            if (t != null)
            {
                db.Thos.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTho(Tho th)
        {

            var t = (from a in db.Thos where a.maTho == th.maTho select a).SingleOrDefault();
            if (t != null)
            {
                t.maTho = th.maTho;
                t.nhom = th.nhom;
                t.nhom_Truong = th.nhom_Truong;
                t.tenTho = th.tenTho;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
