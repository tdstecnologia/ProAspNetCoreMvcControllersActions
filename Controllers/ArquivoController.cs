
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class ArquivoController : Controller
    {
        public VirtualFileResult Imagem()
        {
            return File("~/Imagens/cisco.jpg", "image/jpeg");
        }

    }
}
