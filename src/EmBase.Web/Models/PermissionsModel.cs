using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmBase.Web.Models
{
  public class PermissionsModel
  {
    [DisplayName("Id_Permission")]
    public int Id_Permission { get; set; }

    [DisplayName("Nazwa dostępu")]
    public string Permission_Name { get; set; }

    [DisplayName("Opis dostępu")]
    public string Permission_Description { get; set; }

  }
}