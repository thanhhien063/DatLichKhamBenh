using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Controllers
{
    public class DatLichKhamController : Controller
    {
        WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        public ActionResult DatLichThanhCong()
        {
            return View();
        }

        #region[DatLichKham]

        // GET: DatLichKham
        public ActionResult DatLichKham(string IdTaiKhoan)
        {
            var IdTaiKhoanSession = Code.Utilities.IdTaiKhoanSessionValue;
            if (IdTaiKhoan == null)
            {
                IdTaiKhoan = IdTaiKhoanSession;
            }
            ViewData["IdTaiKhoan"] = IdTaiKhoan;
            datlichhen datlichhen = new datlichhen();
            datlichhen.IdTaiKhoan = IdTaiKhoan;
            return View(datlichhen);
        }

        [HttpPost]
        public ActionResult DatLichKham(FormCollection collection, datlichhen datlichhen)
        {
            DateTime id = DateTime.Now;
            string makhambenh = "BN" + id.Year + id.Month + id.Day + id.Hour + id.Minute + id.Second + id.Millisecond;
            string idTaiKhoan = collection[1];
            string hoVaTen = collection[2];
            string email = collection[3];
            string sdt = collection[4];
            string ngayThangNamSinh = collection[5];
            string gioitinh = collection[6];
            string ngayHen = collection[7];
            string noidung = collection[8];
            string trangThai = "0";
            datlichhen.maKhamBenh = makhambenh;
            datlichhen.hoVaTen = hoVaTen;
            datlichhen.email = email;
            datlichhen.sdt = sdt;
            datlichhen.ngayThangNamSinh = ngayThangNamSinh;
            datlichhen.gioiTinh = gioitinh;
            datlichhen.ngayHen = ngayHen;
            datlichhen.noiDung = noidung;
            datlichhen.trangThai = trangThai;
            datlichhen.IdTaiKhoan = idTaiKhoan;
            db.datlichhens.Add(datlichhen);
            db.SaveChanges();
            //send mail 
            return RedirectToAction("DatLichKham");
        }
        #endregion
    }
}