using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controllers
  {
  [HttpsGet("/")]
  public ActionResult Index()
  {
    return View();
  } 
  }
  
}