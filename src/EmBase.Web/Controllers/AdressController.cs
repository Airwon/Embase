using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class AdressController : Controller
    {
    [HttpGet]
    public ActionResult Index()
        {
          List<Citys> address = null;

          using (var ctx = new ResourcesServicesContext())
          {
            address = ctx.City.ToList();
          }


          return View(address);
        }
    }
}



    