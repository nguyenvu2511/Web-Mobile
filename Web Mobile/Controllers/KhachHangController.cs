using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Web_Mobile.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        dbShopMobileDataContext data = new dbShopMobileDataContext();

        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.KHACHHANGs.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View();
        }
        [HttpPost]
        public ActionResult Create(KHACHHANG kh)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var kh = from s in data.KHACHHANGs where s.MaKH == id select s;
                return View(kh.SingleOrDefault());
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var kHACHHANGs = from s in data.KHACHHANGs where s.MaKH == id select s;
                return View(kHACHHANGs.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
                data.KHACHHANGs.DeleteOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var kHACHHANGs = from s in data.KHACHHANGs where s.MaKH == id select s;
                return View(kHACHHANGs.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
                UpdateModel(kh);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
        }
    }
}