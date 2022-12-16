using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatLichKhamBenh.Models;
using System.Threading.Tasks;

namespace DatLichKhamBenh.Controllers
{
    public class LoginPatientController : Controller
    {
        // GET: LoginPatient
        public ActionResult LoginPatient()
        {
            return View();
        }
        public ActionResult AutherizePatient(TAIKHOAN taiKhoan)
        {
            using (WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities())
            {
                var userDetails = db.TAIKHOANs.Where(x => x.EMAIL == taiKhoan.EMAIL && x.MATKHAU == taiKhoan.MATKHAU && x.IDCHUCVU == "BN").FirstOrDefault();
                if (userDetails == null)
                {
                    taiKhoan.LoginErrorMessage = "Email hoặc mật khẩu không đúng";
                    return View("~/Views/LoginPatient/LoginPatient.cshtml", taiKhoan);
                }
                else
                {
                    Session["EMAIL"] = taiKhoan.EMAIL;
                    Session["MATKHAU"] = taiKhoan.MATKHAU;
                    taiKhoan.LoginErrorMessage = "Đăng nhập thành công";
                    Task.WaitAll(Task.Delay(3000));
                    return RedirectToAction("LogonPatient", "LogonPatient");
                }
            }
        }
    }
}