using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutDemo.Data;

namespace KnokoutDemo.WebApi.Controllers
{
    public class GameController : Controller
    {
        public ActionResult GetGameScore()
        {
            return View();
        }
    }
}
