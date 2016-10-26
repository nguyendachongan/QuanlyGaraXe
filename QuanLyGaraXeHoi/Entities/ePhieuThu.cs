using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhieuThu
    {
        private string soPhieu, soHD, hoTen;
        private DateTime ngayPH;
        private double soTienThu;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
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

        public string SoPhieu
        {
            get
            {
                return soPhieu;
            }

            set
            {
                soPhieu = value;
            }
        }

        public double SoTienThu
        {
            get
            {
                return soTienThu;
            }

            set
            {
                soTienThu = value;
            }
        }

        public DateTime NgayPH
        {
            get
            {
                return ngayPH;
            }

            set
            {
                ngayPH = value;
            }
        }

        public ePhieuThu()
        {
            this.soPhieu = "";
            this.soHD = "";
            this.NgayPH = DateTime.Now;
           ;
            this.hoTen = "";
            this.SoTienThu = 0;
        }

        public ePhieuThu(string soph,string hd,DateTime ngay,string ten,double tienthu)
        {
            this.soPhieu = soph;
            this.soHD = hd;
            this.NgayPH = ngay;
        
            this.hoTen = ten;
            this.SoTienThu = tienthu;
        }
    }
}
