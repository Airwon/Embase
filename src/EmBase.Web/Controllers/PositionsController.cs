using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmBase.Web.Controllers
{
    public class PositionsController : Controller
    {
    [HttpGet]
    public ActionResult Index()
    {
      List<Enities.Positions> positionses = null;

      using (var ctx = new ResourcesServicesContext())
      {
        positionses = ctx.Position.ToList();
      }


      return View(positionses);
    }
  }
}