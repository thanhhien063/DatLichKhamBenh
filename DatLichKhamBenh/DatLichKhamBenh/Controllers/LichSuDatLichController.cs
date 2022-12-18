using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var IdTaiKhoanSession = Code.Utilities.IdTaiKhoanSessionLogonValue;
            if (IdTaiKhoan == null)
            {
                IdTaiKhoan = IdTaiKhoanSession;
            }
            var listHistory = db.datlichhens.Where(p => p.IdTaiKhoan == IdTaiKhoan).ToList();
            return View(listHistory);
        }
        public ActionResult XoaLichSuDatLich(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            datlichhen datlichhen = db.datlichhens.Find(id);
            if (datlichhen == null)
            {
                return HttpNotFound();
            }
            return View(datlichhen);
        }
        // POST: Admin/datlichhens/Delete/5
        [HttpPost, ActionName("XoaLichSuDatLich")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            datlichhen datlichhen = db.datlichhens.Find(id);
            db.datlichhens.Remove(datlichhen);
            db.SaveChanges();
            return RedirectToAction("LichSuDatLich");
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