using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetworkAddressClientManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = new DAL.DatabaseRepository();
            var users = p.GetUsers();
            return View();
        }
    }
}
