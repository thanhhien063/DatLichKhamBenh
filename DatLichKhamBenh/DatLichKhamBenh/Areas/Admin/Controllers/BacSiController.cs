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
    public class BacSiController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();

        // GET: Admin/BacSi
        public ActionResult BacSi()
        {

            return View(db.danhsachbacsis.ToList());
        }

        // GET: Admin/danhsachbacsis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhsachbacsi danhsachbacsi = db.danhsachbacsis.Find(id);
            if (danhsachbacsi == null)
            {
                return HttpNotFound();
            }
            return View(danhsachbacsi);
        }

        #region[Create]

        // GET: DatLichKham
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection, danhsachbacsi danhsachbacsi)
        {
            DateTime id = DateTime.Now;
            string maBacSi = "BS" + id.Year+id.Month+id.Day+id.Hour+id.Minute+id.Second;
            string hoVaTen = collection[1];
            string chucVu = collection[2];
            string sdt = collection[3];
            string diaChi = collection[4];
            string cmnd = collection[5];


            danhsachbacsi.mabacsi = maBacSi;
            danhsachbacsi.hovaten = hoVaTen;
            danhsachbacsi.chucvu = chucVu;
            danhsachbacsi.sdt = sdt;
            danhsachbacsi.diachi = diaChi;
            danhsachbacsi.cmnd = cmnd;


            db.danhsachbacsis.Add(danhsachbacsi);
            db.SaveChanges();


            return RedirectToAction("BacSi");
        }
        #endregion

        // POST: Admin/danhsachbacsis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: Admin/danhsachbacsis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhsachbacsi danhsachbacsi = db.danhsachbacsis.Find(id);
            if (danhsachbacsi == null)
            {
                return HttpNotFound();
            }
            return View(danhsachbacsi);
        }

        // POST: Admin/danhsachbacsis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mabacsi,hovaten,chucvu,sdt,diachi,cmnd")] danhsachbacsi danhsachbacsi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhsachbacsi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("BacSi");
            }
            return View(danhsachbacsi);
        }

        // GET: Admin/danhsachbacsis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhsachbacsi danhsachbacsi = db.danhsachbacsis.Find(id);
            if (danhsachbacsi == null)
            {
                return HttpNotFound();
            }
            return View(danhsachbacsi);
        }

        // POST: Admin/danhsachbacsis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            danhsachbacsi danhsachbacsi = db.danhsachbacsis.Find(id);
            db.danhsachbacsis.Remove(danhsachbacsi);
            db.SaveChanges();
            return RedirectToAction("BacSi");
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