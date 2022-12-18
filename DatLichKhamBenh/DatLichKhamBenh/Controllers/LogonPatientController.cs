using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Controllers
{
    public class LogonPatientController : Controller
    {
        // GET: LogonPatient
        public ActionResult LogonPatient(LoginViewModel model)
        {
            var IdTaiKhoanSessionLogon = Code.Utilities.IdTaiKhoanSessionLogonValue;
            if (IdTaiKhoanSessionLogon == null)
            {
                return RedirectToAction("LoginPatient", "LoginPatient");
            }
            ViewData["IdTaiKhoan"] = model.IdTaiKhoan;
            return View(model);
        }
        public PartialViewResult _LogonHeader(LoginViewModel model)
        {
            ViewData["IdTaiKhoan"] = model.IdTaiKhoan;
            return PartialView(model);
        }
    }
}