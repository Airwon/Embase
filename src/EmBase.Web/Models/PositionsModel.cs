using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmBase.Web.Models
{
  public class PositionsModel
  {
    [DisplayName("Id_Position")]
    public int Id_Position { get; set; }

    [DisplayName("Stanowisko")]
    public string Position_name { get; set; }
  }
}