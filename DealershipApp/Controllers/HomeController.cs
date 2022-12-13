using Microsoft.AspNetCore.Mvc;
using DealershipApp.Models;
using System.Collections.Generic;

namespace DealershipApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Cars> allCars = Cars.GetAll(); //static allows this to occur. No new instance is needed for car
            return View(allCars);
        }
        [HttpGet("/clearform")]
        public ActionResult ClearForm()
        {
            List<Cars> allCars = Cars.GetAll(); //static allows this to occur. No new instance is needed for car
            return View(allCars);
        }

        [HttpGet("/car/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/car/add")]
        public ActionResult Create(string name, string make, string model)
        {
            string description = String.Format("Name: {0}, Make: {1}, Model: {2}", name, make, model);
            Cars myCars = new Cars(description);
            return RedirectToAction("Index");
        }
        [HttpPost("/car/delete")]
        public ActionResult Clear()
        {
            Cars.ClearAll();
            return RedirectToAction("ClearForm");
        }
    }
}