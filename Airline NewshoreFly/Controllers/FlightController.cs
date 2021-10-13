using Airline_NewshoreFly.FligthReference1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace Airline_NewshoreFly.Controllers
{
    public class FlightController : Controller
    {
        FligthReference1.FligthServiceClient cliente = new FligthReference1.FligthServiceClient();

        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Find(string origen, string destino, DateTime fechaLlegada)
        {
            var listFligths = cliente.FindFligths(origen,destino,fechaLlegada); 
            return Newtonsoft.Json.JsonConvert.SerializeObject(listFligths,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }      
       
    }
}