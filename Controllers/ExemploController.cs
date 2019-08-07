using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class ExemploController : Controller
    {
        public ViewResult Index()
        {
            return View("/Views/Admin/Index.cshtml");
        }

        public ViewResult Admin()
        {
            return View("~/Views/Admin/Index.cshtml");
        }
    }
}
