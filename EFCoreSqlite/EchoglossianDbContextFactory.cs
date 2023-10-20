using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreSqlite
{

  public class EchoglossianDbContextFactory : IDesignTimeDbContextFactory<EchoglossianDbContext>
  {
    public EchoglossianDbContext CreateDbContext(string[] args)
    {
      // You can hard-code the configDir for design time or fetch it from some configuration.
      var configDir = "your_config_directory_here";
      return new EchoglossianDbContext(configDir);
    }
  }
}