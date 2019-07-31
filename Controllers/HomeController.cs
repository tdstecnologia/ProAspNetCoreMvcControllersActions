using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("FormularioSimples");
        public ViewResult FormularioSemParametro()
        {
            var nome = Request.Form["nome"];
            var cidade = Request.Form["cidade"];
            return View("Resultado", $"{nome} vive em {cidade}");
        }

        public ViewResult Formulario(string nome, string cidade) => View("Resultado", $"{nome} mora em {cidade}");
    }
}
