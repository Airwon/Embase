using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class Model_EquimpmentsEditController : Controller
    {
    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Addproccess(Model_Equimpments modelEquimpments)
    {

      var modelEquimpment = new Model_Equimpments
      {


        Mark = modelEquimpments.Mark,
        Model = modelEquimpments.Model,


      };



      using (var ctx = new ResourcesServicesContext())
      {
        ctx.Model_Equimpment.Add(modelEquimpment);
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Model_Equimpments");

    }


    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Model_Equimpments modelEquimpments = null;
      using (var ctx = new ResourcesServicesContext())
      {
        modelEquimpments = ctx.Model_Equimpment.SingleOrDefault(x => x.Id_Model == symbol);
      }

      var model_only = new Model_Equimpments
      {


        Mark = modelEquimpments.Mark,
        Model = modelEquimpments.Model,

      };

      return View(model_only);
    }



    [HttpPost]
    public ActionResult Editing(Model_Equimpments model_only)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var model_eq = ctx.Model_Equimpment.SingleOrDefault(x => x.Id_Model == model_only.Id_Model);

        model_eq.Mark = model_only.Mark;
        model_eq.Model = model_only.Model;


        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Model_Equimpments");
    }
  }
}