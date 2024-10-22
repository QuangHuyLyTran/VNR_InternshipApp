using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VNR_InternShipApp.Models;
using System.Data.Entity;

namespace VNR_InternShipApp.Controllers
{
    public class KhoaHocController : Controller
    {
        private VNRDbContext db = new VNRDbContext();

        // Action lấy danh sach khoa hoc va tra ve view
        public ActionResult Index()
        {
            var khoaHocs = db.KhoaHocs.ToList();

            return View(khoaHocs);
        }

        // Action lay danh sach mon hoc theo id khoa hoc
        public JsonResult GetMonHocByKhoaHocId(int id)
        {
            var monHocs = db.MonHocs.Where(m => m.KhoaHocID == id)
                                    .Select(m => new { m.TenMonHoc }).ToList();

            if (monHocs.Any())
            {
                return Json(new { success = true, data = monHocs }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "Không tìm thấy môn học nào" }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}