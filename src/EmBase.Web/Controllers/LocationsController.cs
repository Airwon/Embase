using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;
using EmBase.Web.Models;

namespace EmBase.Web.Controllers
{
    public class LocationsController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }


    [HttpPost]
    public ActionResult Adding( LocationWithCityModel locationWithCityModel)
    {

      var city = new Citys
      {

        Id_City=locationWithCityModel.Id_City,
        City = locationWithCityModel.City,
        Street = locationWithCityModel.Street,
        Postal_Code = locationWithCityModel.Postal_Code,

      };

      var locations = new Locations
      {
Id_City = locationWithCityModel.Id_City,
Id_Locations = locationWithCityModel.Id_Locations,
    Floor = locationWithCityModel.Floor,
        Room = locationWithCityModel.Room

      };

      using (var ctx = new ResourcesServicesContext())
      {
        ctx.City.Add(city);
        ctx.Location.Add(locations);
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Location");
    } 


    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Citys city = null;
      Locations locations= null;
      using (var ctx = new ResourcesServicesContext())
      {
        city = ctx.City.SingleOrDefault(x => x.Id_City == symbol);
       locations= ctx.Location.SingleOrDefault(x => x.Id_Locations == symbol);
      }

      var locationswithcity = new LocationWithCityModel
      {

        City = city.City,
        Street = city.Street,
        Postal_Code = city.Postal_Code,
        Floor = locations.Floor,
        Room = locations.Room
      };
      return View(locationswithcity);

    }

    [HttpPost]
    public ActionResult Editing(LocationWithCityModel locationswithcity)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var city = ctx.City.SingleOrDefault(x => x.Id_City == locationswithcity.Id_Locations);
        var locaiton = ctx.Location.SingleOrDefault(x => x.Id_Locations == locationswithcity.Id_Locations);
        city.City = locationswithcity.City;
        city.Postal_Code=locationswithcity.Postal_Code;
        city.Street = locationswithcity.Street;
        locaiton.Id_Locations = locationswithcity.Id_Locations;
        locaiton.Floor = locationswithcity.Floor;
        locaiton.Room = locationswithcity.Room;
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Location");
    }


  }
}