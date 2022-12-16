using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatLichKhamBenh.Models;

namespace DatLichKhamBenh.Areas.Admin.Controllers
{
    public class TaiKhoanController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();

        // GET: Admin/TaiKhoan
        public ActionResult TaiKhoan()
        {
            return View(db.TAIKHOANs.ToList());
        }

        // GET: Admin/TaiKhoan/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }
        #region[Create]
        // GET: Admin/TaiKhoan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TaiKhoan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection, TAIKHOAN taikhoan)
        {
            DateTime id = DateTime.Now;
            string IDTAIKHOAN = "TK" + id.Year + id.Month + id.Day + id.Hour + id.Minute + id.Second;
            string HOTEN = collection[1];
            DateTime NGAYSINH = DateTime.Now;
            string GIOITINH = collection[3];
            string SODT = collection[4];
            string DIACHI = collection[5];
            string EMAIL = collection[6];
            string MATKHAU = collection[7];
            string IDCHUCVU = collection[8];


            taikhoan.IDTAIKHOAN = IDTAIKHOAN;
            taikhoan.HOTEN = HOTEN;
            taikhoan.NGAYSINH = NGAYSINH;
            taikhoan.GIOITINH = GIOITINH;
            taikhoan.SODT = SODT;
            taikhoan.DIACHI = DIACHI;
            taikhoan.EMAIL = EMAIL;
            taikhoan.MATKHAU = MATKHAU;
            taikhoan.IDCHUCVU = IDCHUCVU;


            db.TAIKHOANs.Add(taikhoan);
            db.SaveChanges();


            return RedirectToAction("TaiKhoan");
        }
        #endregion

        // GET: Admin/TaiKhoan/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // POST: Admin/TaiKhoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HOTEN,NGAYSINH,GIOITINH,SODT,DIACHI,EMAIL,MATKHAU,IDTAIKHOAN,IDCHUCVU")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAIKHOAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TaiKhoan");
            }
            return View(tAIKHOAN);
        }

        // GET: Admin/TaiKhoan/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // POST: Admin/TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            db.TAIKHOANs.Remove(tAIKHOAN);
            db.SaveChanges();
            return RedirectToAction("TaiKhoan");
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
