using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class PocoController : Controller
    {
        public ViewResult Index()
        {
            ViewResult ViewResultado = new ViewResult()
            {
                ViewName = "Resultado",
                ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(),
                    new ModelStateDictionary())
                {
                    Model = $"This is a POCO controller"
                }
            };
            return ViewResultado;
        }

        public ViewResult Headers()
        {

            ViewResult viewResultado = new ViewResult()
            {
                ViewName = "MapaResultado", ViewData = new ViewDataDictionary( new EmptyModelMetadataProvider(),new ModelStateDictionary())
                {
                    Model = ControllerContext.HttpContext.Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())
                }
            };
            return viewResultado;
        }
    }
}
