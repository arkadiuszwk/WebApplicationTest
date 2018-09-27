using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index(string name)
        {
            return View();
        }
    }
}