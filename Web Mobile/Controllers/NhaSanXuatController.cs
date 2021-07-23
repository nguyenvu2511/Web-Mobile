using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Web_Mobile.Controllers
{
    public class NhaSanXuatController : Controller
    {
        // GET: NhaSanXuat
        dbShopMobileDataContext data = new dbShopMobileDataContext();
            
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.NhaSanXuats.ToList());
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
        public ActionResult Create(NhaSanXuat nsx)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                data.NhaSanXuats.InsertOnSubmit(nsx);
                data.SubmitChanges();
                return RedirectToAction("Index", "NhaSanXuat");
            }
        }
        public ActionResult Details(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var nsx = from s in data.NhaSanXuats where s.MaNSX == id select  s;
                return View(nsx.SingleOrDefault());
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var nsx = from s in data.NhaSanXuats where s.MaNSX == id select s;
                return View(nsx.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                NhaSanXuat nsx = data.NhaSanXuats.SingleOrDefault(n => n.MaNSX == id);
                data.NhaSanXuats.DeleteOnSubmit(nsx);
                data.SubmitChanges();
                return RedirectToAction("Index", "NhaSanXuat");
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var nsx = from s in data.NhaSanXuats where s.MaNSX == id select s;
                return View(nsx.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                NhaSanXuat nsx = data.NhaSanXuats.SingleOrDefault(n => n.MaNSX == id);
                UpdateModel(nsx);
                data.SubmitChanges();
                return RedirectToAction("Index", "NhaSanXuat");
            }
        }
    }
}