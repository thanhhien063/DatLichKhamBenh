using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DatLichKhamBenh.Controllers
{
    public class LichSuDatLichController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        // GET: LichSuDatLich
        public ActionResult LichSuDatLich(string IdTaiKhoan)
        {
            var IdTaiKhoanSession = Code.Utilities.IdTaiKhoanSessionValue;
            if (IdTaiKhoan == null)
            {
                IdTaiKhoan = IdTaiKhoanSession;
            }
            var listHistory = db.datlichhens.Where(p => p.IdTaiKhoan == IdTaiKhoan).ToList();
            return View(listHistory);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}