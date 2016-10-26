using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTho
    {
        private string maTho,tenTho,nhom,nhomTruong;

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

        public string Nhom
        {
            get
            {
                return nhom;
            }

            set
            {
                nhom = value;
            }
        }

        public string NhomTruong
        {
            get
            {
                return nhomTruong;
            }

            set
            {
                nhomTruong = value;
            }
        }

        public string TenTho
        {
            get
            {
                return tenTho;
            }

            set
            {
                tenTho = value;
            }
        }

        public eTho()
        {
            this.maTho = "";
            this.tenTho = "";
            this.nhom = "";
            this.NhomTruong = "";
        }

        public eTho(string ma,string ten,string nhom,string ntruong)
        {
            this.maTho = ma;
            this.tenTho = ten;
            this.nhom = nhom;
            this.NhomTruong = ntruong;
        }
    }
}
