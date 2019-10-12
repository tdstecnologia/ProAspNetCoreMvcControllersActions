using Microsoft.AspNetCore.Mvc;


namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
