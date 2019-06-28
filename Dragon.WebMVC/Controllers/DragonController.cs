using Dragon.Models;
using Dragon.Services;
using Microsoft.AspNet.Identity;
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DragonCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DragonService(userId);

            service.CreateDragon(model);

            return RedirectToAction("Index");
        }
    }
}