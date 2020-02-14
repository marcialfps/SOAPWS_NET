using _WS.Unit05.Example2.Web.WSClient.ApplicationWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _WS.Unit05.Example2.Web.Controllers
{
    public class ProductController : Controller
    {
        protected string GetIPAddress()
        {
            return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
           .AddressList[1].ToString();
        }
        // GET: Products
        public ActionResult Index()
        {
            ApplicationServicesSoapClient application = new ApplicationServicesSoapClient();
            return View(application.GetProducts());
        }
        // GET: Products
        public ActionResult Product(string name)
        {
            string ip = GetIPAddress();
            Array zones = Enum.GetValues(typeof(Zone));
            Zone randomZone = (Zone)zones.GetValue(Math.Abs(ip.GetHashCode()) % zones.Length);
            ApplicationServicesSoapClient application = new ApplicationServicesSoapClient();
            return View(application.GetProduct(name, Zone.CENTER));
        }
    }
}