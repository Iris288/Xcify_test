using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XcifyTestCode.Models;


namespace XcifyTestCode.Controllers
{
    public class HomeController : Controller
    {
        private XcifySampleTestDB objProductDbEntities;

        public HomeController()
        {
            objProductDbEntities = new XcifySampleTestDB();
        }
        public ActionResult Index()
        {


            return View();
        }

        public JsonResult GetAllProduct()
        {
            var ProductGet = (from obj in objProductDbEntities.tblProducts select new
                                {
                                    Name = obj.Name,
                                    Price = obj.Price
                                }

                            ).ToList();
            return Json(ProductGet, JsonRequestBehavior.AllowGet);

            
        }
    }
}