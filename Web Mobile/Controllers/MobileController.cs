using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;
using PagedList;
using PagedList.Mvc;
namespace Shop_Mobile.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            var dt = data.SanPhams.Where(a=> a.MaLSP==1).ToList();

            return View(dt);
            
            
        }
        dbShopMobileDataContext data = new dbShopMobileDataContext();

        private List<SanPham> Layspmoi(int count)
        {
     
                return data.SanPhams.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
            
        }

        public ActionResult Details(int id)
        {
            var sanPhams = from s in data.SanPhams
                           where s.MaSP == id
                           select s;

            return View(sanPhams.Single());


        }
        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult DienThoai(int? page)
        {
            int pageSize = 8;
            int pageNum = (page ?? 1);
            var dt = data.SanPhams.Where(a => a.MaLSP==1).ToList();
            return View(dt.ToPagedList(pageNum, pageSize));
        }
        public ActionResult NhaSanXuat()
        {
            var nsx = from s in data.NhaSanXuats select s;

            return PartialView(nsx);
        }
        public ActionResult SPTheoNSX(int? page, int id)
        {
            int pageSize = 8;
            int pageNum = (page ?? 1);
            var sp = data.SanPhams.Where(a => a.MaNSX == id && a.MaLSP == 1);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Tablet(int? page)
        {
            int pageSize = 8;
            int pageNum = (page ?? 1);
            var sp = data.SanPhams.Where(a => a.MaLSP == 2);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
        public ActionResult PhuKien(int? page)
        {
            int pageSize = 8;
            int pageNum = (page ?? 1);
            var sp = data.SanPhams.Where(a => a.MaLSP == 3);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
    }
}