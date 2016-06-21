using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class PermissionsEditController : Controller
    {
    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Adding(Permissions permissions)
    {

      var permission = new Permissions
      {


        Permission_Name = permissions.Permission_Name,
        Permission_Description = permissions.Permission_Description,


      };
    


      using (var ctx = new ResourcesServicesContext())
      {
        ctx.Permission.Add(permission);
        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Permissions");

    }


    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Permissions permissions = null;
      using (var ctx = new ResourcesServicesContext())
      {
        permissions = ctx.Permission.SingleOrDefault(x => x.Id_Permission == symbol);
      }

      var permision_only = new Permissions
      {


        Permission_Name = permissions.Permission_Name,
        Permission_Description = permissions.Permission_Description,

      };

      return View(permision_only);
    }



    [HttpPost]
    public ActionResult Editing(Permissions permision_only)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var model_eq = ctx.Permission.SingleOrDefault(x => x.Id_Permission == permision_only.Id_Permission);

        model_eq.Permission_Name = permision_only.Permission_Name;
        model_eq.Permission_Description = permision_only.Permission_Description;


        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Model_Equimpments");
    }
  }
}