using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CheckController : Controller
    {
        //
        // GET: /Check/
        public ActionResult Index()
        {
            MBH m = new MBH();
            m.abc = 1234;

            return View("Index",m);
        }
	}
}