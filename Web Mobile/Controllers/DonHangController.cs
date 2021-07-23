using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Web_Mobile.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang

        dbShopMobileDataContext data = new dbShopMobileDataContext();
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.DONDATHANGs.ToList());
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var dh = from s in data.DONDATHANGs where s.MaDH == id select s;
                return View(dh.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                DONDATHANG dh = data.DONDATHANGs.SingleOrDefault(n => n.MaDH == id);
                data.DONDATHANGs.DeleteOnSubmit(dh);
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
                var dh = from s in data.DONDATHANGs where s.MaDH == id select s;
                return View(dh.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                DONDATHANG dh = data.DONDATHANGs.SingleOrDefault(n => n.MaDH == id);
                UpdateModel(dh);
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
                var dh = from s in data.DONDATHANGs where s.MaDH == id select s;
                return View(dh.SingleOrDefault());
            }
        }
    }
}