using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;

namespace NetworkAddressClientManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = new DAL.DatabaseRepository();
            var users = p.GetUsers();
            IPAddress address = IPAddress.Parse("192.168.100.1");
            
    
            return View();
        }
    }
}
