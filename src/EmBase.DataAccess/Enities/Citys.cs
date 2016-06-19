using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBase.Enities
{
  public class Citys
  {

    [Key]
    public int Id_City { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string Postal_Code { get; set; }

  }
}
