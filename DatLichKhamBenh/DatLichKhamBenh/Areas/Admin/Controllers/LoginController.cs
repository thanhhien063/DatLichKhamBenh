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
                var userDetails = db.TAIKHOANs.Where(x => x.EMAIL == taiKhoan.EMAIL && x.MATKHAU == taiKhoan.MATKHAU && x.IDCHUCVU != "BN").FirstOrDefault();
                if (userDetails == null)
                {
                    taiKhoan.LoginErrorMessage = "Email hoặc mật khẩu không đúng. Tài khoản không phải tài khoản Quản trị";
                    return View("Login", taiKhoan);
                }
                //if (userDetails = db.TAIKHOANs.Where(x => x.IDCHUCVU != "BN"))
                //{

                //}
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
