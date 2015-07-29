using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDealershipProject.ViewModels;
using MVCDealershipProject.Models;

namespace MVCDealershipProject.Controllers
{
    public class HomeController : Controller
    {
        private VehicleDBContext db = new VehicleDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Inventory Statistics";
            var data =
                from vehicle in db.Vehicles
                group vehicle by new {makeG = vehicle.Make, modelG = vehicle.Model, yearG = vehicle.Year } into vehicleGroup
                orderby vehicleGroup.Key.makeG
                 select new InventoryGroup()
                 {
                     Make = vehicleGroup.Key.makeG,
                     Model = vehicleGroup.Key.modelG,
                     Year = vehicleGroup.Key.yearG,
                     VehicleCount = vehicleGroup.Count()
        };

            return View(data);
        }
        
        protected override void Dispose(bool disposing)
         {
             db.Dispose();
             base.Dispose(disposing);
         }		         

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}