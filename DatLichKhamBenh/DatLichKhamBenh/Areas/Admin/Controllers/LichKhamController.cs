using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Areas.Admin.Controllers
{
    public class LichKhamController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        // GET: Admin/LichKham
        public ActionResult LichKham()
        {
            return View(db.datlichhens.ToList());
        }

        // GET: Admin/datlichhens/Details/5
        public ActionResult Details(string id)
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

        #region[Create]

        // GET: DatLichKham
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection, datlichhen datlichhen)
        {
            DateTime id = DateTime.Now;
            string maKhamBenh = "BN" + id.Year + id.Month + id.Day + id.Hour + id.Minute + id.Second;
            string hoVaTen = collection[1];
            string email = collection[2];
            string sdt = collection[3];
            string ngayThangNamSinh = collection[4];
            string gioiTinh = collection[5];
            string ngayHen = collection[6];
            string noiDung = collection[7];
            string trangThai = "0";

            datlichhen.maKhamBenh = maKhamBenh;
            datlichhen.hoVaTen = hoVaTen;
            datlichhen.email = email;
            datlichhen.sdt = sdt;
            datlichhen.ngayThangNamSinh = ngayThangNamSinh;
            datlichhen.gioiTinh = gioiTinh;
            datlichhen.ngayHen = ngayHen;
            datlichhen.noiDung = noiDung;
            datlichhen.trangThai = trangThai;

            db.datlichhens.Add(datlichhen);
            db.SaveChanges();


            return RedirectToAction("LichKham");
        }
        #endregion
        // GET: Admin/datlichhens/Edit/5
        public ActionResult Edit(string id)
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

        // POST: Admin/datlichhens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maKhamBenh,hoVaTen,email,sdt,ngayThangNamSinh,gioiTinh,ngayHen,noiDung,trangThai")] datlichhen datlichhen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datlichhen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LichKham");
            }
            return View(datlichhen);
        }

        // GET: Admin/datlichhens/Delete/5
        public ActionResult Delete(string id)
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
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            datlichhen datlichhen = db.datlichhens.Find(id);
            db.datlichhens.Remove(datlichhen);
            db.SaveChanges();
            return RedirectToAction("LichKham");
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