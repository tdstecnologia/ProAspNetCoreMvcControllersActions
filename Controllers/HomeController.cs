using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

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

        public void ReceberFormulario(string nome, string cidade)
        {
            Response.StatusCode = 200;
            Response.ContentType = "text/html";
            byte[] content = Encoding.ASCII
            .GetBytes($"<html><body>{nome} vive em {cidade}</body>");
            Response.Body.WriteAsync(content, 0, content.Length);
        }

        public ViewResult DataAtual() => View("DataAtual", DateTime.Now);

        public IActionResult Resultado() => View((object)"Mensagem");

        public ViewResult ViewBagParametro()
        {
            ViewBag.Mensagem = "Mensagem";
            ViewBag.Data = DateTime.Now;
            return View("ViewBag");
        }

        public RedirectResult Redirecionar()
        {
            return Redirect("/home/index");
        }

    }

}
