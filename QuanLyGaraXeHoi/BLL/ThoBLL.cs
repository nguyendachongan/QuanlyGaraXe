using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class ThoBLL
    {
        ThoDAL tdal = new ThoDAL();
        public List<eTho> getAllTho()
        {
            List<eTho> listet = new List<eTho>();
            List<Tho> listt = new List<Tho>();
            listt = tdal.getAllTho();
            foreach(Tho t in listt)
            {
                eTho et = new eTho();
                et.MaTho = t.maTho;
                et.Nhom = t.nhom;
                et.NhomTruong = t.nhom_Truong;
                et.TenTho = t.tenTho;
                listet.Add(et);   
            }
            return listet;
        }

        public eTho getTho(string ma)
        {
            eTho et = new eTho();
            Tho t = new Tho();
            t = tdal.getTho(ma);
            et.MaTho = t.maTho;
            et.Nhom = t.nhom;
            et.NhomTruong = t.nhom_Truong;
            et.TenTho = t.tenTho;
            return et;
        }

        public bool themTho(eTho et)
        {
            Tho t = new Tho();
            t.maTho = et.MaTho;
            t.nhom = et.Nhom;
            t.nhom_Truong = et.NhomTruong;
            t.tenTho = et.TenTho;
            return tdal.themTho(t);
        }

        public bool xoaTho(string ma)
        {
            return tdal.xoaTho(ma);
        }

        public bool suaTho(eTho et)
        {
            Tho t = new Tho();
            t.maTho = et.MaTho;
            t.nhom = et.Nhom;
            t.nhom_Truong = et.NhomTruong;
            t.tenTho = et.TenTho;
            return tdal.suaTho(t);

        }
    }
}
