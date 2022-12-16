using DatLichKhamBenh.Models;
using System.Web.Mvc;
using System.Linq;

namespace DatLichKhamBenh.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        WebDatLichKhamBenhEntities db = new WebDatLichKhamBenhEntities();
        // GET: Admin/Menu
        public ActionResult Menu()
        {
            return View();
        }
        public PartialViewResult LoadMenuCha()
        {
            var menucha = (from mn in db.MENUs where mn.IDPARENT == null select mn).ToList();
            return PartialView(menucha);
        }
        public PartialViewResult LoadMenuCon(string IDMenuCha)
        {
            var menucon = (from mn in db.MENUs where mn.IDPARENT==IDMenuCha select mn).ToList();
            return PartialView(menucon);
        }

    }
}