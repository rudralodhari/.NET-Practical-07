
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeedBackManagmentSystem.Models;

namespace FeedBackManagmentSystem.Controllers
{
    public class FeedBackController : Controller
    {
        static List<FeedBack> FeedBackList = new List<FeedBack>();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FeedBack feedBack)
        {
            FeedBackList.Add(feedBack);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(FeedBackList);
        }
    }
}
