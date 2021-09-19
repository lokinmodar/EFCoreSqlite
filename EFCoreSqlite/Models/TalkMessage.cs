using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreSqlite.Models
{
  [Table("talkmessages")]
  public class TalkMessage : BaseEntity
  {
    [Key] public int Id { get; set; }
    [Required] [MaxLength(100)] public string SenderName { get; set; }
    [Required] [MaxLength(400)] public string OriginalTalkMessage { get; set; }
    [Required] public string OriginalSenderNameLang { get; set; }
    [Required] public string OriginalTalkMessageLang { get; set; }
    [MaxLength(100)] public string TranslatedSenderName { get; set; }
    [MaxLength(400)] public string TranslatedTalkMessage { get; set; }
    [Required] public string TranslationLang { get; set; }


    public TalkMessage(string senderName, string originalTalkMessage, string originalTalkMessageLang, string originalSenderNameLang, string translatedSenderName,
      string translatedTalkMessage, string translationLang)
    {
      SenderName = senderName;
      OriginalTalkMessage = originalTalkMessage;
      OriginalSenderNameLang = originalSenderNameLang;
      OriginalTalkMessageLang = originalTalkMessageLang;
      TranslatedSenderName = translatedSenderName;
      TranslatedTalkMessage = translatedTalkMessage;
      TranslationLang = translationLang;
    }
  }
}
