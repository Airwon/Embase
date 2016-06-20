using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class Model_EquimpmentsController : Controller
    {
    [HttpGet]
    public ActionResult Index()
    {
      List<Model_Equimpments> modelEquimpmentses = null;

      using (var ctx = new ResourcesServicesContext())
      {
        modelEquimpmentses = ctx.Model_Equimpment.ToList();
      }


      return View(modelEquimpmentses);
    }
  }
}