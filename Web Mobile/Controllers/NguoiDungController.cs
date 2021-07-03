using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;

namespace Shop_Mobile.Controllers
{

    public class NguoiDungController : Controller
    {
        dbShopMobileDataContext db = new dbShopMobileDataContext();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
       
        public ActionResult DangKy(FormCollection Collection, KHACHHANG kh)
        {
            var hoten = Collection["HoTenKH"];
            var tendn = Collection["TenDN"];
            var matkhau = Collection["MatKhau"];
            var matkhaunhaplai = Collection["MatKhauNhapLai"];
            var diachi = Collection["DiaChi"];
            var email = Collection["email"];
            var DienThoai = Collection["DienThoai"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", Collection["NgaySinh"]);
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ Tên Khách Hàng Không Được Để Trống";

            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Phải Nhập Tên Đăng Nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải Nhập Mật Khẩu";
            }
            else if (String.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi4"] = "Phải Nhập lại Mật Khẩu";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "email không được để trống";
            }
            if (String.IsNullOrEmpty(diachi))
            {
                ViewData["Loi6"] = "Địa chỉ không được để trống";
            }
            if (String.IsNullOrEmpty(DienThoai))
            {
                ViewData["Loi7"] = "phải nhập số Điện Thoại";
            }
            else
            {
                kh.HoTen = hoten;
                kh.Taikhoan = tendn;
                kh.Matkhau = matkhau;
                kh.Email = email;
                kh.DiachiKH = diachi;
                kh.DienthoaiKH = DienThoai;
                kh.Ngaysinh = DateTime.Parse(ngaysinh);
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                
                return RedirectToAction("DangNhap");


            }
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection Collection )
        {
            var tendn = Collection["TenDN"];
            var matkhau = Collection["MatKhau"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải Nhập Tên Đăng Nhập";

            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải Nhập Mat Khẩu";

            }
            else
            {
                KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(n => n.Taikhoan == tendn && n.Matkhau == matkhau);
                if (kh != null)
                {
                    ViewBag.ThongBao = "Chúc Mừng Đăng nhập thành công";
                    Session["TaiKhoan"] = kh;
                    return RedirectToAction("Index", "Mobile");
                }
                else
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
    }
}