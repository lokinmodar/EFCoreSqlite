using System;
using System.IO;
using System.Linq;
using System.Reflection;
using EFCoreSqlite.Models;
using EFCoreSqlite.Models.Journal;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSqlite
{
  public class EchoglossianDbContext : DbContext
  {
    public DbSet<ToastMessage> ToastMessage { get; set; }
    public DbSet<TalkMessage> TalkMessage { get; set; }
    public DbSet<BattleTalkMessage> BattleTalkMessage { get; set; }
    public DbSet<QuestPlate> QuestPlate { get; set; }
    public string DbPath { get; private set; }

    public EchoglossianDbContext()
    {
      var dbPath = Directory.GetParent(Assembly.GetExecutingAssembly().Location)?.ToString();
      DbPath = $"{dbPath}{System.IO.Path.DirectorySeparatorChar}Echoglossian.db";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite($"Data Source={DbPath}");

 public override int SaveChanges()
     {
       var entries = ChangeTracker
         .Entries()
         .Where(e => e.Entity is BaseEntity && (
           e.State == EntityState.Added
           || e.State == EntityState.Modified));

       foreach (var entityEntry in entries)
       {
         ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

         if (entityEntry.State == EntityState.Added)
         {
           ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
         }
       }


/*var addedEntities = ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Added).ToList();

addedEntities.ForEach(e =>
{
e.Entity.CreatedDate = DateTime.Now;
});

var modifiedEntities = ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Modified).ToList();

modifiedEntities.ForEach(e =>
{
e.Entity.UpdatedDate = DateTime.Now;
});*/

return base.SaveChanges();


}
}

}