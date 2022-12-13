using Microsoft.AspNetCore.Mvc;
using DealershipApp.Models;

namespace DealershipApp.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {
      return View();
    }
  }
}