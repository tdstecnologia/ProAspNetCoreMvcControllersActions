using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() => View("Resultado", $"This is a derived controller");

        public ViewResult Headers()
        {
            return View("MapaResultado", Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First()));
        }
    }
}
