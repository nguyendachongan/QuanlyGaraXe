using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCV
    {
        private string maCV, noidungCV;

        public string MaCV
        {
            get
            {
                return maCV;
            }

            set
            {
                maCV = value;
            }
        }

        public string NoidungCV
        {
            get
            {
                return noidungCV;
            }

            set
            {
                noidungCV = value;
            }
        }

        public eCV()
        {
            maCV = "";
            noidungCV = "";
        }
        public eCV(string ma,string nd)
        {
            maCV = ma;
            noidungCV = nd;
        }
    }
}
