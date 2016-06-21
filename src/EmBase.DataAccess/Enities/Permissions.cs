using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBase.Enities
{
 public  class Permissions
  {
    [Key]

    public int Id_Permission { get; set; }

    public string Permission_Name { get; set; }

    public string Permission_Description { get; set; }

  }
}
