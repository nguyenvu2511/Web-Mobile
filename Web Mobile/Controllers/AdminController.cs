using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Web_Mobile.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        dbShopMobileDataContext data = new dbShopMobileDataContext();
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["Taikhoanadmin"] != null)
                return RedirectToAction("Index", "Admin");
            else
                return View();

        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            // Gán các giá trị người dùng nhập liệu cho các biến 
            var tendn = collection["txtUser"];
            var matkhau = collection["txtPass"];

                //Gán giá trị cho đối tượng được tạo mới (ad)        

                Admin ad = data.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    // ViewBag.Thongbao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";

            return View();
        }

        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Login", "Admin");
        }

        public ActionResult TaiKhoan()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
                return View(data.Admins.ToList());
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
        public ActionResult Create(Admin admin)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                data.Admins.InsertOnSubmit(admin);
                data.SubmitChanges();
                return RedirectToAction("TaiKhoan");
            }
        }
        public ActionResult Details(string id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var admin = from s in data.Admins where s.UserAdmin == id select s;
                return View(admin.SingleOrDefault());
            }
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var admin = from s in data.Admins where s.UserAdmin == id select s;
                return View(admin.SingleOrDefault());
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Xacnhanxoa(string id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                Admin admin = data.Admins.SingleOrDefault(n => n.UserAdmin == id);
                data.Admins.DeleteOnSubmit(admin);
                data.SubmitChanges();
                return RedirectToAction("TaiKhoan");
            }
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                var admin = from s in data.Admins where s.UserAdmin == id select s;
                return View(admin.SingleOrDefault());
            }
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Xacnhansua(string id)
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("Login", "Admin");
            else
            {
                Admin admin = data.Admins.SingleOrDefault(n => n.UserAdmin == id);
                UpdateModel(admin);
                data.SubmitChanges();
                return RedirectToAction("TaiKhoan");
            }
        }
    }
}