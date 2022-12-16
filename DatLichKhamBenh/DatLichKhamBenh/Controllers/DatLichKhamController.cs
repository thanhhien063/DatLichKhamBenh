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
        public ActionResult DatLichKham()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DatLichKham(FormCollection collection, datlichhen datlichhen)
        {
            DateTime id = DateTime.Now;
            string makhambenh = "BN" + id.Year + id.Month + id.Day + id.Hour + id.Minute + id.Second + id.Millisecond;
            string hoVaTen = collection[1];
            string email = collection[2];
            string sdt = collection[3];
            string ngayThangNamSinh = collection[4];
            string gioitinh = collection[5];
            string ngayHen = collection[6];
            string noidung = collection[7];
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

            db.datlichhens.Add(datlichhen);
            db.SaveChanges();

            //send mail 

            


            return RedirectToAction("DatLichThanhCong");
        }
        #endregion
    }
}