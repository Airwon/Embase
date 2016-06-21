using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class PositionEditController : Controller
    {
    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Addproccess(Positions positions)
    {

      var positiont = new Positions
      {


        Position_name = positions.Position_name,



      };



      using (var ctx = new ResourcesServicesContext())
      {
        ctx.Position.Add(positiont);
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Positions");

    }


    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Positions positions = null;
      using (var ctx = new ResourcesServicesContext())
      {
        positions = ctx.Position.SingleOrDefault(x => x.Id_Position == symbol);
      }

      var posit_only = new Positions
      {


        Position_name = positions.Position_name,
 

      };

      return View(posit_only);
    }



    [HttpPost]
    public ActionResult Editing(Positions posit_only1)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var model_eq = ctx.Position.SingleOrDefault(x => x.Id_Position == posit_only1.Id_Position);

        model_eq.Position_name = posit_only1.Position_name;
   


        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Model_Equimpments");
    }
  }
}