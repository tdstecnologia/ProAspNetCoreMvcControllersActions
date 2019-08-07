using Microsoft.AspNetCore.Mvc;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class RetornoController : Controller
    {
        public JsonResult Index()
        {
            return Json(new[] { "Ana","Bia","Clara"});
        }

        public ContentResult Conteudo()
        {
            return Content("<h1>Content Result</h1>", "text/html");
        }

        public OkObjectResult Status()
        {
            return Ok(new[] { "Ana", "Bia", "Clara" });
        }
    }
}
