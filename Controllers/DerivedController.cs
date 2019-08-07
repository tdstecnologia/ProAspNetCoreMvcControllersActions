using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() => View("Resultado", $"This is a derived controller");

        public ViewResult Headers()
        {
            Debug.WriteLine("Path: " + Request.Path);
            Debug.WriteLine("Path: " + Request.QueryString);

            return View("MapaResultado", Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First()));
        }

        public ViewResult Headers2()
        {
            return new ViewResult()
            {
                ViewName = "MapaResultado",
                ViewData = new ViewDataDictionary(
                new EmptyModelMetadataProvider(),
                new ModelStateDictionary())
                {
                    Model = ControllerContext.HttpContext.Request.Headers
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())
                }
            };

        }
    }
}
