using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Controllers
{
    public class RegisterPatientController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        // GET: RegisterPatient
        public ActionResult RegisterPatient()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterPatient(FormCollection collection, TAIKHOAN taikhoan)
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
            string IDCHUCVU = "BN";


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


            return RedirectToAction("Index", "TrangChu");
        }
    
    }
}