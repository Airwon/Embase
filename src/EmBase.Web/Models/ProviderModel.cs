using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EmBase.Web.Models
{
    public class ProviderModel
    {

    [Key]

    [DisplayName("Id_Providers")]
    public int Id_Providers { get; set; }

    [DisplayName("Nazwa firmy")]
    public string Company_Name { get; set; }

    [DisplayName("Ulica")]
    public string StreetProv { get; set; }

    [DisplayName("Kod pocztowy")]
    public string PostCodeProv { get; set; }

    [DisplayName("Miasto")]
    public string CityProv { get; set; }

    [DisplayName("Nip")]
    public string Nip_Prov { get; set; }

    }
}