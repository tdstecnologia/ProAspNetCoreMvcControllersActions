using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class RedirecionamentoController : Controller
    {
        public RedirectResult Index()
        {
            //return Redirect("Redirecionamento/Admin");
            return Redirect("/Redirecionamento/Admin");

            // Redireciona para o Controller Admin
            //return Redirect("Admin");
        }
        public RedirectResult Permanente()
        {
            return RedirectPermanent("/Redirecionamento/Admin");
        }

        public RedirectToRouteResult Rota()
        {
            return RedirectToRoute(new { controller = "Redirecionamento", action = "Permanente", id = "10"});
        }
        public ViewResult Admin()
        {
            return View("~/Views/Admin/Index.cshtml");
        } 

        public RedirectToActionResult Redirecionar()
        {
            return RedirectToAction("index","Exemplo");
        }
    }
}
