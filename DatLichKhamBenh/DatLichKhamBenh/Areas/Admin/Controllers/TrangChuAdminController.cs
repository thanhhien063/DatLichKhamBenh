using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Areas.Admin.Controllers
{
    public class TrangChuAdminController : Controller
    {
        private WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        // GET: Admin/TrangChuAdmin
        public ActionResult IndexAdmin()
        {
            var tongSoDatLich = db.datlichhens.OrderByDescending(model => model.maKhamBenh);
            ViewBag.tongSoDatLich = tongSoDatLich.Count();

            var tongSoBacSi = db.danhsachbacsis.OrderByDescending(model => model.mabacsi);
            ViewBag.tongSoBacSi = tongSoBacSi.Count();

            var tongSoBenhNhanDaKham = db.datlichhens.Where(model => model.trangThai == "1");
            ViewBag.tongSoBenhNhanDaKham = tongSoBenhNhanDaKham.Count();

            var tongSoBenhNhanChuaKham = db.datlichhens.Where(model => model.trangThai == "0");
            ViewBag.tongSoBenhNhanChuaKham = tongSoBenhNhanChuaKham.Count();
            return View();
        }
    }
}