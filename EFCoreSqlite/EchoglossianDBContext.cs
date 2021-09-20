// <copyright file="EchoglossianDBContext.cs" company="lokinmodar">
// Copyright (c) lokinmodar. All rights reserved.
// Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International Public License license.
// </copyright>

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using EFCoreSqlite.Models;
using EFCoreSqlite.Models.Journal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFCoreSqlite
{
  public class EchoglossianDbContext : DbContext
  {
    public DbSet<ToastMessage> ToastMessage { get; set; }

    public DbSet<TalkMessage> TalkMessage { get; set; }

    public DbSet<BattleTalkMessage> BattleTalkMessage { get; set; }

    public DbSet<QuestPlate> QuestPlate { get; set; }

    public string DbPath { get; }

    public EchoglossianDbContext()
    {
      var dbPath = Directory.GetParent(Assembly.GetExecutingAssembly().Location)?.ToString();
      this.DbPath = $"{dbPath}{Path.DirectorySeparatorChar}Echoglossian.db";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.

    /// <inheritdoc/>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source={this.DbPath}");
      optionsBuilder.LogTo(this.logStream.WriteLine).EnableSensitiveDataLogging().EnableDetailedErrors();
    }

    private readonly StreamWriter logStream = new($"{Directory.GetParent(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}dantecontextlog.txt", append: true);

    /// <inheritdoc/>
    public override void Dispose()
    {
      base.Dispose();
      this.logStream.Dispose();
    }

    /// <inheritdoc/>
    public override async ValueTask DisposeAsync()
    {
      await base.DisposeAsync();
      await this.logStream.DisposeAsync();
    }

    /*public override int SaveChanges()
    {
      var entries = this.ChangeTracker
        .Entries()
        .Where(e => e.Entity is BaseEntity && (
          e.State == EntityState.Added
          || e.State == EntityState.Modified));
      var enumerable = entries as EntityEntry[] ?? entries.ToArray();
      var entityEntries = entries as EntityEntry[] ?? enumerable.ToArray();
      File.AppendAllLines($"{Directory.GetParent(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}dantelog.txt", new[] { "entries antes do foreach", entityEntries.ToString() });
      foreach (var entityEntry in entityEntries)
      {
        ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

        if (entityEntry.State == EntityState.Added)
        {
          ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
        }
      }

      var entityEntries2 = entries as EntityEntry[] ?? enumerable.ToArray();
      File.AppendAllLines($"{Directory.GetParent(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}dantelog.txt", new[] { "entries depois do foreach", entityEntries2.ToString() });
      return base.SaveChanges();
    }*/
  }
}