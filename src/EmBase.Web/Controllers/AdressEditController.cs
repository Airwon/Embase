using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class AdressEditController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

      [HttpPost]
      public ActionResult Addproccess(Citys citys)
      {

      var city = new Citys
      {


        City = citys.City,
        Street = citys.Street,
       Postal_Code = citys.Postal_Code,

      };



      using (var ctx = new ResourcesServicesContext())
      {
        ctx.City.Add(city);
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Adress");

    }


    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Citys city = null;
      using (var ctx = new ResourcesServicesContext())
      {
        city = ctx.City.SingleOrDefault(x => x.Id_City == symbol);
      }

      var city_only = new Citys
      {
        Id_City = city.Id_City,
        City = city.City,
        Street = city.Street,
        Postal_Code = city.Postal_Code
      };

      return View(city_only);
    }



    [HttpPost]
    public ActionResult Editing( Citys  city_only)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var city = ctx.City.SingleOrDefault(x => x.Id_City == city_only.Id_City);


        city.City = city_only.City;
        city.Street = city_only.Street;
        city.Postal_Code = city_only.Postal_Code;

        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Adress");
    }
  }
}



