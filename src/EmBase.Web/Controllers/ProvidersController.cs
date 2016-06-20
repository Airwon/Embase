using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Web.Models;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class ProvidersController : Controller
    {
    [HttpGet]
    public ActionResult Index()
    {
      List<ProviderModel> providers = null;
      using (var ctx = new ResourcesServicesContext())
      {

        providers = ctx.Provider.Select(x => new ProviderModel
        {

          Id_Providers=x.Id_Providers,
          CityProv = x.CityProv,
          Company_Name=x.Company_Name,
          StreetProv=x.StreetProv,
          PostCodeProv=x.PostCodeProv,
          Nip_Prov=x.Nip_Prov
 

        }).ToList();
      }

      return View(providers);
    }
    }
}