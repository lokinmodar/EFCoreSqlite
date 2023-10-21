using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSqlite.Migrations
{
    /// <inheritdoc />
    public partial class EchoglossianDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "battletalkmessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SenderName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OriginalBattleTalkMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false),
                    OriginalSenderNameLang = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalBattleTalkMessageLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedSenderName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TranslatedBattleTalkMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_battletalkmessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locationnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginalLocationName = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false),
                    OriginalLocationNameLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedLocationName = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locationnames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "npcnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginalNpcName = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false),
                    OriginalNpcNameLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedNpcName = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_npcnames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "questplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestId = table.Column<string>(type: "TEXT", nullable: false),
                    QuestName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    OriginalQuestMessage = table.Column<string>(type: "TEXT", maxLength: 2500, nullable: false),
                    OriginalLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedQuestName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    TranslatedQuestMessage = table.Column<string>(type: "TEXT", maxLength: 2500, nullable: false),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
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
                    SenderName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OriginalTalkMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false),
                    OriginalSenderNameLang = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalTalkMessageLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedSenderName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TranslatedTalkMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talkmessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "talksubtitlemessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginalTalkSubtitleMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false),
                    OriginalTalkSubtitleMessageLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedTalkSubtitleMessage = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talksubtitlemessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "toastmessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ToastType = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    OriginalToastMessage = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    OriginalLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslatedToastMessage = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    TranslationLang = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationEngine = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "BLOB", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toastmessages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "battletalkmessages");

            migrationBuilder.DropTable(
                name: "locationnames");

            migrationBuilder.DropTable(
                name: "npcnames");

            migrationBuilder.DropTable(
                name: "questplates");

            migrationBuilder.DropTable(
                name: "talkmessages");

            migrationBuilder.DropTable(
                name: "talksubtitlemessages");

            migrationBuilder.DropTable(
                name: "toastmessages");
        }
    }
}
