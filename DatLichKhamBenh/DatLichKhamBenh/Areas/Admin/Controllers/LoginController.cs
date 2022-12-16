using DatLichKhamBenh.Models;
using System.Linq;
using System.Web.Mvc;

namespace DatLichKhamBenh.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
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
                    return RedirectToAction("IndexAdmin", "TrangChuAdmin");
                }
            }
        }
    }
}
