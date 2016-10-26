using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eHopDong
    {
        private string soHD, maKH, soXe,tenKH,diachi;
        private DateTime ngayHD, ngaygiao, ngayngthu;
        private double triGiaHD;
        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
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

        public string SoXe
        {
            get
            {
                return soXe;
            }

            set
            {
                soXe = value;
            }
        }

        public double TriGiaHD
        {
            get
            {
                return triGiaHD;
            }

            set
            {
                triGiaHD = value;
            }
        }

        public DateTime NgayHD
        {
            get
            {
                return ngayHD;
            }

            set
            {
                ngayHD = value;
            }
        }

        public DateTime Ngaygiao
        {
            get
            {
                return ngaygiao;
            }

            set
            {
                ngaygiao = value;
            }
        }

        public DateTime Ngayngthu
        {
            get
            {
                return ngayngthu;
            }

            set
            {
                ngayngthu = value;
            }
        }
        
        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public eHopDong()
        {
            this.soHD = "";
            this.Ngaygiao = DateTime.Now;
            this.NgayHD = DateTime.Now;
            this.tenKH = "";
            this.diachi = "";
            this.maKH = "";
            this.soXe = "";
            this.Ngayngthu = DateTime.Now;
            this.triGiaHD = 0;
        }
        public eHopDong(string hd,string ma,string ten,string dc,DateTime nghd,string so, double gia,DateTime ngiao,DateTime ngngthu)
        {
            this.soHD = hd;
            this.TenKH = ten;
            this.Diachi = dc;
            this.Ngaygiao = ngiao;
            this.NgayHD = nghd;
            this.maKH = ma;
            this.soXe = so;
            this.Ngayngthu = ngngthu;
            this.triGiaHD = gia;
        }
    }
}
