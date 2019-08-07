using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcControllersActions.Controllers
{
    public class StatusHttpController : Controller
    {

        public StatusCodeResult Index()
        {
            //return StatusCode(StatusCodes.Status200OK);
            return StatusCode(StatusCodes.Status404NotFound);
        }

        public StatusCodeResult Status()
        {
            return Ok();
            //return NotFound();
        }

    }
}
