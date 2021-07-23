using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;
namespace Web_Mobile.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSP
        dbShopMobileDataContext data = new dbShopMobileDataContext();

        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.LoaiSanPhams.ToList());
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
        public ActionResult Create(LoaiSanPham loaiSanPham)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                data.LoaiSanPhams.InsertOnSubmit(loaiSanPham);
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
                var loaiSanPham = from s in data.LoaiSanPhams where s.MaLSP == id select s;
                return View(loaiSanPham.SingleOrDefault());
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var loaiSanPham = from s in data.LoaiSanPhams where s.MaLSP == id select s;
                return View(loaiSanPham.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                LoaiSanPham loaiSanPham = data.LoaiSanPhams.SingleOrDefault(n => n.MaLSP == id);
                data.LoaiSanPhams.DeleteOnSubmit(loaiSanPham);
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
                var loaiSanPham = from s in data.LoaiSanPhams where s.MaLSP == id select s;
                return View(loaiSanPham.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(int id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                LoaiSanPham loaiSanPham = data.LoaiSanPhams.SingleOrDefault(n => n.MaLSP == id);
                UpdateModel(loaiSanPham);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
        }
    }
}