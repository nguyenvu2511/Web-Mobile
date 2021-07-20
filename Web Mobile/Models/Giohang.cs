using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Mobile.Models;

namespace Web_Mobile.Models
{
    public class Giohang
    {
        dbShopMobileDataContext data = new dbShopMobileDataContext();
        public int iMaSp { get; set; }
        public String sTenSP { get; set; }

        public String sHinhChinh { get; set; }

        public double dDongia { get; set; }
        public int iSoluong { get; set; }
        public double dThanhtien
        {
            get { return iSoluong * dDongia; }

        }
        public Giohang(int MaSp)
        {
            iMaSp = MaSp;
            SanPham sanPham = data.SanPhams.Single(n => n.MaSP == iMaSp);
            sTenSP = sanPham.TenSP;
            sHinhChinh = sanPham.HinhChinh;
            dDongia = double.Parse(sanPham.Giaban.ToString());
            iSoluong = 1;

        }

    }
}