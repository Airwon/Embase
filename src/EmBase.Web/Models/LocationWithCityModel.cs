using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmBase.Web.Models
{
    public class LocationWithCityModel
    {
  
    [DisplayName("Id_Locations")]
    public int Id_Locations { get; set; }
  
    [DisplayName("Id_City ")]
    public int Id_City { get; set; }

    [DisplayName("Miasto")]
    public string City { get; set; }

    [DisplayName("Ulica")]
    public string Street { get; set; }

    [DisplayName("Kod pocztowy")]
    public string Postal_Code { get; set; }

    [DisplayName("Piętro")]
    public int Floor { get; set; }

    [DisplayName("Pomieszczenie")]
    public int Room { get; set; }


  }
    
}