using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using EFCoreSqlite;
using EFCoreSqlite.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreSqlite
{
  public class DbOperations
  {
    private EchoglossianDbContext context;
    public DbOperations()
    {
      this.context = new EchoglossianDbContext();
    }
    public string dbPath = $"{Directory.GetParent(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}dantelog.txt";

    public void CreateOrUseDb()
    {
      // using var context = new EchoglossianDbContext();
      context.Database.MigrateAsync();
    }

    public TalkMessage FindTalkMessage(TalkMessage talkMessage)
    {
      // using var context = new EchoglossianDbContext();
      File.AppendAllLines(dbPath, new[] { talkMessage.SenderName.ToString() });
      var existingTalkMessage =
        context.TalkMessage.Where(t => t.OriginalTalkMessage == talkMessage.OriginalTalkMessage).Where(t => t.TranslationLang == talkMessage.TranslationLang);
      File.AppendAllLines(dbPath, new[] {existingTalkMessage.FirstOrDefault()?.SenderName.ToString()});
      return existingTalkMessage.FirstOrDefault()?.TranslatedSenderName != null ? existingTalkMessage.FirstOrDefault() : talkMessage;
    }


    public ToastMessage FindToastMessage(ToastMessage toastMessage)
    {
      // using var context = new EchoglossianDbContext();
      var existingToastMessage =
        context.ToastMessage.Where(t => t.OriginalToastMessage == toastMessage.OriginalToastMessage);
      return existingToastMessage.First().TranslatedToastMessage != "" ? existingToastMessage.First() : toastMessage;
    }

    public BattleTalkMessage FindBattleTalkMessage(BattleTalkMessage battleTalkMessage)
    {
      // using var context = new EchoglossianDbContext();
      var existingBattleTalkMessage =
        context.BattleTalkMessage.Where(t => t.OriginalBattleTalkMessage == battleTalkMessage.OriginalBattleTalkMessage);
      return existingBattleTalkMessage.First().TranslatedBattleTalkMessage != "" ? existingBattleTalkMessage.First() : battleTalkMessage;
    }

    public string InsertTalkData(TalkMessage talkMessage)
    {
      // using var context = new EchoglossianDbContext();
      try
      {
        File.AppendAllLines(dbPath, new[] {talkMessage.SenderName.ToString()});
        //1. Attach an entity to context with Added EntityState
        context.TalkMessage.Attach(talkMessage);

        File.AppendAllLines(dbPath, new []{ context.TalkMessage.ToString()});

        //or the followings are also valid
        // context.Students.Add(std);
        // context.Entry<Student>(std).State = EntityState.Added;
        // context.Attach<Student>(std);

        //2. Calling SaveChanges to insert a new record into Students table
        context.SaveChanges();
        return "Data inserted to TalkMessages table.";
      }
      catch (Exception e)
      {
        return $"ErrorSavingData: {e}";
      }
    }

    public string InsertBattleTalkData(BattleTalkMessage battleTalkMessage)
    {
      // using var context = new EchoglossianDbContext();

      try
      {
        //1. Attach an entity to context with Added EntityState
        context.Attach(battleTalkMessage);

        //or the followings are also valid
        // context.Students.Add(std);
        // context.Entry<Student>(std).State = EntityState.Added;
        // context.Attach<Student>(std);

        //2. Calling SaveChanges to insert a new record into Students table
        context.SaveChanges();
        return "Data inserted to BattleTalkMessages table.";
      }
      catch (Exception e)
      {
        return $"Error: {e.StackTrace}";
      }
    }

    public string InsertToastMessageData(ToastMessage toastMessage)
    {
      // using var context = new EchoglossianDbContext();

      try
      {
        // 1. Attach an entity to context with Added EntityState
        context.Attach(toastMessage);

        /* or the followings are also valid
         context.Students.Add(std);
         context.Entry<Student>(std).State = EntityState.Added;
         context.Attach<Student>(std); */

        //2. Calling SaveChanges to insert a new record into Students table
        context.SaveChanges();
        return "Data inserted to ToastMessages table.";
      }
      catch (Exception e)
      {
        return $"Error: {e.StackTrace}";
      }
    }

  }
}