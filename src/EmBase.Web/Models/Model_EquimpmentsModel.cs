using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmBase.Web.Models
{
  public class Model_EquimpmentsModel
  {
    [DisplayName("Id_Model")]
    public int Id_Model { get; set; }
    [DisplayName("Marka")]
    public string Mark { get; set; }
    [DisplayName("Model")]
    public string Model { get; set; }
  }
}