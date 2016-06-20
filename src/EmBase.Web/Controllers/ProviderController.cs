using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmBase.Enities;

namespace EmBase.Web.Controllers
{
    public class ProviderController : Controller
    {
    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }

      [HttpPost]
      public ActionResult Adding(Providers providers)
      {

        var provider = new Providers
        {

          Company_Name = providers.Company_Name,
          StreetProv = providers.StreetProv,
          PostCodeProv = providers.PostCodeProv,
          CityProv = providers.CityProv,
          Nip_Prov = providers.Nip_Prov

        };



        using (var ctx = new ResourcesServicesContext())
        {
          ctx.Provider.Add(provider);
          ctx.SaveChanges();
        }

        return RedirectToAction("Index", "Providers");

      }

    [HttpGet]
    public ActionResult Edit(int symbol)
    {
      Providers provider = null;
      using (var ctx = new ResourcesServicesContext())
      {
        provider = ctx.Provider.SingleOrDefault(x => x.Id_Providers == symbol);
      }

      var providersonly = new Providers
      {
        Company_Name = provider.Company_Name,
        CityProv = provider.CityProv,
        StreetProv = provider.StreetProv,
        PostCodeProv = provider.PostCodeProv,
        Nip_Prov = provider.Nip_Prov
      };

      return View(providersonly);
    }



    [HttpPost]
    public ActionResult Editing(Providers providers_only)
    {
      using (var ctx = new ResourcesServicesContext())
      {
        var providers = ctx.Provider.SingleOrDefault(x => x.Id_Providers == providers_only.Id_Providers);


        providers.Company_Name = providers_only.Company_Name;
        providers.CityProv = providers_only.CityProv;
        providers.StreetProv = providers_only.StreetProv;
        providers.PostCodeProv = providers_only.PostCodeProv;
        providers.Nip_Prov = providers_only.Nip_Prov;

        ctx.SaveChanges();
      }

      return RedirectToAction("Index", "Providers");
    }

  }
}