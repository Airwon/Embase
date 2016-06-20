using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class PermissionsController : Controller
    {
    [HttpGet]
    public ActionResult Index()
    {
      List<Permissions> permision= null;

      using (var ctx = new ResourcesServicesContext())
      {
        permision = ctx.Permission.ToList();
      }


      return View(permision);
    }
  }
}