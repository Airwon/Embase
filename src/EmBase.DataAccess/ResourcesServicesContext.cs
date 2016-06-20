using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmBase.Enities;

namespace EmBase
{
 public  class ResourcesServicesContext : DbContext
  {

    public ResourcesServicesContext() : base("name=EmBaseConnect")
  {
    }

    public DbSet <Citys> City { get; set; }
    public DbSet<Locations> Location{ get; set; }
    public DbSet<Providers> Provider{ get; set; }
    public DbSet<Model_Equimpments> Model_Equimpment { get; set; }
    public DbSet<Positions> Position { get; set; }
    public DbSet<Permissions> Permission { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }

  
}


