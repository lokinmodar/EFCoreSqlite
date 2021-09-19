using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreSqlite.Models
{
  [Table("battletalkmessages")]
  public class BattleTalkMessage : BaseEntity
  {
    [Key] public int Id { get; set; }
    [Required] [MaxLength(100)] public string SenderName { get; set; }
    [Required] [MaxLength(400)] public string OriginalBattleTalkMessage { get; set; }
    [Required] public string OriginalLang { get; set; }
    [MaxLength(400)] public string TranslatedBattleTalkMessage { get; set; }
    [Required] public string TranslationLang { get; set; }


    public BattleTalkMessage(string senderName, string originalBattleTalkMessage, string originalLang,
      string translatedBattleTalkMessage, string translationLang)
    {
      SenderName = senderName;
      OriginalBattleTalkMessage = originalBattleTalkMessage;
      OriginalLang = originalLang;
      TranslatedBattleTalkMessage = translatedBattleTalkMessage;
      TranslationLang = translationLang;
    }
  }
}
