using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eChiTietHopDong
    {
        private string soHD,maCV, maTho;
        private double triGiaCV,khoanTho;
        
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

        public string MaTho
        {
            get
            {
                return maTho;
            }

            set
            {
                maTho = value;
            }
        }


        public double TriGiaCV
        {
            get
            {
                return triGiaCV;
            }

            set
            {
                triGiaCV = value;
            }
        }

        public double KhoanTho
        {
            get
            {
                return khoanTho;
            }

            set
            {
                khoanTho = value;
            }
        }

        public string SoHD
        {
            get
            {
                return soHD;
            }

            set
            {
                soHD = value;
            }
        }

        public eChiTietHopDong()
        {
            this.soHD = "";
            this.maCV = "";
            this.triGiaCV = 0;
            this.maTho = "";
            this.KhoanTho = 0;
        }


        public eChiTietHopDong(string hd,string cv,double gia,string tho,double luong)
        {
            this.soHD = hd;
            this.maCV = cv;
            this.triGiaCV = gia;
            this.maTho = tho;
            this.KhoanTho = luong;
        }
    }
}
