using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Web_Mobile.Controllers
{
    public class CTDonHangController : Controller
    {
        // GET: CTDonHang
        dbShopMobileDataContext data = new dbShopMobileDataContext();
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.CHITIETDONTHANGs.ToList());
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var dh = from s in data.CHITIETDONTHANGs where s.MaDH == id select s;
                return View(dh.FirstOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                CHITIETDONTHANG dh = data.CHITIETDONTHANGs.FirstOrDefault(n => n.MaDH == id);
                data.CHITIETDONTHANGs.DeleteOnSubmit(dh);
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
                var dh = from s in data.CHITIETDONTHANGs where s.MaDH == id select s;
                return View(dh.FirstOrDefault());
            }
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                CHITIETDONTHANG dh = data.CHITIETDONTHANGs.SingleOrDefault(n => n.MaDH == id);
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
                var dh = from s in data.CHITIETDONTHANGs where s.MaDH == id select s;
                return View(dh.FirstOrDefault());
            }
        }
    }
}