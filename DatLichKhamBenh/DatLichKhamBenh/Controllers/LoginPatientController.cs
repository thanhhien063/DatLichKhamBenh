using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatLichKhamBenh.Models;

namespace DatLichKhamBenh.Controllers
{
    public class LoginPatientController : Controller
    {
        // GET: LoginPatient
        public ActionResult LoginPatient()
        {
            return View();
        }
        public ActionResult Autherize(TAIKHOAN taiKhoan)
        {
            using (WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities())
            {
                var userDetails = db.TAIKHOANs.Where(x => x.EMAIL == taiKhoan.EMAIL && x.MATKHAU == taiKhoan.MATKHAU).FirstOrDefault();
                if (userDetails == null)
                {
                    taiKhoan.LoginErrorMessage = "Email hoặc mật khẩu không đúng";
                    return View("Login", taiKhoan);
                }
                else
                {
                    Session["EMAIL"] = taiKhoan.EMAIL;
                    Session["MATKHAU"] = taiKhoan.MATKHAU;
                    return RedirectToAction("Index", "TrangChu");
                }
            }
        }
    }
}