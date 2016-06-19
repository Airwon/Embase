using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBase.Enities
{
  public class Providers
  {
    [Key]
    public int Id_Providers { get; set; }

    public string Company_Name { get; set; }

    public string StreetProv { get; set; }

    public string PostCodeProv { get; set; }

    public string CityProv { get; set; }

    public string Nip_Prov { get; set; }



  }
}
