using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;
using EmBase.Web.Models;

namespace EmBase.Web.Controllers
{
    public class LocationController : Controller
    {
    [HttpGet]
    public ActionResult Index()
        {
      List<Citys> address = null;
      List<Locations> locationses = null;
      using (var ctx = new ResourcesServicesContext())
      {
        address = ctx.City.ToList();
        locationses = ctx.Location.ToList();

      }

      var citywithadressquerry = from c in address
                                 join a in locationses on c.Id_City equals a.Id_City
                                 select new LocationWithCityController
                                 {


                                   City = c.City,
                                   Street = c.Street,
                                   Postal_Code = c.Postal_Code,
                                   Floor = a.Floor,
                                   Room = a.Room


                                 };
      var citywithadress = citywithadressquerry.ToList();
      return View(citywithadress);
    }
    }
}




