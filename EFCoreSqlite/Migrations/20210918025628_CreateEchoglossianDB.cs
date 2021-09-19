using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSqlite.Migrations
{
  public partial class CreateEchoglossianDB : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "battletalkmessages",
          columns: table => new
          {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            SenderName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
            OriginalBattleTalkMessage = table.Column<string>(type: "VARCHAR", maxLength: 400, nullable: false),
            OriginalLang = table.Column<string>(type: "VARCHAR", nullable: false),
            TranslatedBattleTalkMessage = table.Column<string>(type: "VARCHAR", maxLength: 400, nullable: true),
            TranslationLang = table.Column<string>(type: "VARCHAR", nullable: false),
            CreatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: false),
            UpdatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_battletalkmessages", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "questplates",
          columns: table => new
          {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            QuestName = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
            OriginalQuestMessage = table.Column<string>(type: "VARCHAR", maxLength: 2500, nullable: false),
            OriginalLang = table.Column<string>(type: "VARCHAR", nullable: false),
            TranslatedQuestMessage = table.Column<string>(type: "VARCHAR", maxLength: 2500, nullable: true),
            TranslationLang = table.Column<string>(type: "VARCHAR", nullable: false),
            CreatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: false),
            UpdatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_questplates", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "talkmessages",
          columns: table => new
          {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            SenderName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
            OriginalTalkMessage = table.Column<string>(type: "VARCHAR", maxLength: 400, nullable: false),
            OriginalSenderNameLang = table.Column<string>(type: "VARCHAR", nullable: false),
            OriginalTalkMessageLang = table.Column<string>(type: "VARCHAR", nullable: false),
            TranslatedSenderName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: true),
            TranslatedTalkMessage = table.Column<string>(type: "VARCHAR", maxLength: 400, nullable: true),
            TranslationLang = table.Column<string>(type: "VARCHAR", nullable: false),
            CreatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: false),
            UpdatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_talkmessages", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "toastmessages",
          columns: table => new
          {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            ToastType = table.Column<string>(type: "VARCHAR", maxLength: 40, nullable: false),
            OriginalToastMessage = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
            OriginalLang = table.Column<string>(type: "VARCHAR", nullable: false),
            TranslatedToastMessage = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: true),
            TranslationLang = table.Column<string>(type: "VARCHAR", nullable: false),
            CreatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: false),
            UpdatedDate = table.Column<DateTime>(type: "DATETIME", rowVersion: true, nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_toastmessages", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "battletalkmessages");

      migrationBuilder.DropTable(
          name: "questplates");

      migrationBuilder.DropTable(
          name: "talkmessages");

      migrationBuilder.DropTable(
          name: "toastmessages");
    }
  }
}
