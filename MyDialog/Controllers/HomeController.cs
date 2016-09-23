using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDialog.Models;
using MyDialog.Data;

namespace MyDialog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CarModel> model = CarRepository.GetCars();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            CarModel model = CarRepository.GetCars().Where(c => c.Id == id).FirstOrDefault();
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Edit(CarModel model)
        {
            if(ModelState.IsValid)
            {
                CarModel car = CarRepository.GetCars().Where(c => c.Id == model.Id).FirstOrDefault();
                car.Name = model.Name;
                car.Description = model.Description;
                return Content(Boolean.TrueString);
            }
            else
            {
                return Content("Please review your form");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}