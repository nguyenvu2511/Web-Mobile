using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Mobile.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace Web_Mobile.Controllers
{
    public class SanPhamController : Controller
    {
        dbShopMobileDataContext data = new dbShopMobileDataContext();
        // GET: SanPham
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] != null)
                return View();

            else
                return RedirectToAction("Login", "Admin");
        }
        public ActionResult QuanLySanPham(int? page)
        {
           
            int pagenumber = (page ?? 1);
            int pagesize = 7;

            if (Session["Taikhoanadmin"] != null)
                return View(data.SanPhams.ToList().OrderByDescending(n=>n.MaSP).ToPagedList(pagenumber, pagesize));

            else
                return RedirectToAction("Login", "Admin");

        }
        public ActionResult ThemMoiSP()
        {

            if (Session["Taikhoanadmin"] != null)
            {
                ViewBag.MaLSP = new SelectList(data.LoaiSanPhams.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
                ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
                return View();
            }



            else
                return RedirectToAction("Login", "Admin");

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiSP(SanPham sanPham, HttpPostedFileBase fileupload)
        {
            //Dua du lieu vao dropdownload

            ViewBag.MaLSP = new SelectList(data.LoaiSanPhams.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            //Kiem tra duong dan file
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn hình sản phẩm";
                return View();
            }
            //Them vao CSDL
            else
            {
                if (ModelState.IsValid)
                {
                    //Luu ten fie, luu y bo sung thu vien using System.IO;
                    var fileName = Path.GetFileName(fileupload.FileName);
                    //Luu duong dan cua file
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    //Kiem tra hình anh ton tai chua?
                    if (System.IO.File.Exists(path))
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    else
                    {
                        //Luu hinh anh vao duong dan
                        fileupload.SaveAs(path);
                    }
                    sanPham.HinhChinh = fileName;
                    sanPham.Hinh1 = fileName;
                    sanPham.Hinh2 = fileName;
                    sanPham.Hinh3 = fileName;

                    //Luu vao CSDL
                    data.SanPhams.InsertOnSubmit(sanPham);
                    data.SubmitChanges();
                }
                return RedirectToAction("QuanLySanPham", "SanPham");
            }
        }
        public ActionResult Chitietsanpham(int id)
        {
            SanPham sanPham = data.SanPhams.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sanPham.MaSP;
            if (sanPham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sanPham);
        }
        [HttpGet]
        public ActionResult XoaSP(int id)
        {
            SanPham sanPham = data.SanPhams.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sanPham.MaSP;
            if (sanPham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sanPham);
        }
        [HttpPost, ActionName("XoaSP")]
        public ActionResult XacNhanXoa(int id)
        {

            SanPham sanPham = data.SanPhams.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sanPham.MaSP;
            if (sanPham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.SanPhams.DeleteOnSubmit(sanPham);
            data.SubmitChanges();
            return RedirectToAction("QuanLySanPham");
        }
        [HttpGet]
        public ActionResult SuaSP(int id)
        {

            SanPham sanPham = data.SanPhams.SingleOrDefault(n => n.MaSP == id);

            if (sanPham == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            ViewBag.MaLSP = new SelectList(data.LoaiSanPhams.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");

            return View(sanPham);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaSP(int id, HttpPostedFileBase fileupload)
        {
            //Dua du lieu vao dropdownload
            SanPham sanPham = data.SanPhams.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaLSP = new SelectList(data.LoaiSanPhams.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            //Kiem tra duong dan file
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn hình sản phẩm";
                return View();
            }
            //Them vao CSDL
            else
            {
                if (ModelState.IsValid)
                {
                    //Luu ten fie, luu y bo sung thu vien using System.IO;
                    var fileName = Path.GetFileName(fileupload.FileName);
                    //Luu duong dan cua file
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    //Kiem tra hình anh ton tai chua?
                    if (System.IO.File.Exists(path))
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    else
                    {
                        //Luu hinh anh vao duong dan
                        fileupload.SaveAs(path);
                    }
                    sanPham.HinhChinh = fileName;
                    //Luu vao CSDL
                    UpdateModel(sanPham);
                    data.SubmitChanges();
                }
                return RedirectToAction("QuanLySanPham", "SanPham");
            }
        }
    }
}