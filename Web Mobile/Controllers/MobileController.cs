using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Shop_Mobile.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            var dtmoi = Layspmoi(8);
            
                return View(dtmoi);
            
            
        }
        dbShopMobileDataContext data = new dbShopMobileDataContext();

        private List<SanPham> Layspmoi(int count)
        {
            var dt = data.LoaiSanPhams.Where(p => p.MaLSP==1).ToList();
            {
                return data.SanPhams.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
            }
            
        }

        public ActionResult Details(int id)
        {
            var sanPhams = from s in data.SanPhams
                           where s.MaSP == id
                           select s;

            return View(sanPhams.Single());


        }


    }
}