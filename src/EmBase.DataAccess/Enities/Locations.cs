using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBase.Enities
{
  public class Locations
  {

    [Key]
    public int Id_Locations { get; set; }

    public int Id_City { get; set; }

    public int  Floor { get; set; }

    public int Room { get; set; }
  }
}
