using Dvtlesso06FCK22CNTT4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dvtlesso06FCK22CNTT4.Controllers
{
    public class DvtCategoriesController : Controller
    {
        private static DvtBookStore bhpDb;
       public  BhpCategoriesController()
        { 
            bhpDb = new DvtBookStore();
        }
        // GET: DvtCategories
        public ActionResult DvtIndex()
        {
            /*
             *  khởi tạo DbContext:
             *  EF sẽ tìm thông tin kết nối trong file machinee.config của .NET framework trên máy
             *  và sau đó tạo cơ sở dữ liệu
             *  **/
            // DvtBookstore DvtDb=new Dvtbookstore();
            DvtBookStore DvtDb = new DvtBookStore();
            var bvtcategories = DvtDb.dvtCategories.ToList();
            return View(bhpcategories);
        }
        public ActionResult DvtCreate()
        {
            var dvtCategory = new DvtCategory();
            return View(dvtCategory);
        }
        [HttpPost]
        public ActionResult DvtCreate(DvtCategory dvtCategory)
        {
            dvtDb.dvtCategories.Add(dvtCategory);
            dvtDb.SaveChanges();

            return RedirectToAction("DvtIndex");
        }
    }
}