using Microsoft.AspNetCore.Mvc;
using DealershipApp.Models;
using System.Collections.Generic;
 
namespace DealershipApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() {
      List<Cars> allCars = Cars.GetAll();
      return View(allCars);
    }

    [HttpGet("/car/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/car")]
    public ActionResult Create(string name, string make, string model)
    {
      string description = String.Format("Name: {0}, Make: {1}, Model: {2}", name, make, model);
      Cars myCars = new Cars(description);
      return RedirectToAction("Index");
    }
  }
}