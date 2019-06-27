using Dragon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dragon.WebMVC.Controllers
{
    // 
    [Authorize]
    public class DragonController : Controller
    {
        // GET: Dragon 2 3
        public ActionResult Index()
        {
            // 4
            var model = new DragonListItem[0];
            return View(model);
        }
        //add method - Get
        public ActionResult Create()
        {
            return View();
        }
    }
}