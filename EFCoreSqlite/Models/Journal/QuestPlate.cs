using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreSqlite.Models.Journal
{
  [Table("questplates")]
  public class QuestPlate : BaseEntity
  {
    [Key] public int Id { get; set; }
    [Required] [MaxLength(200)] public string QuestName { get; set; }
    [Required] [MaxLength(2500)] public string OriginalQuestMessage { get; set; }
    [Required] public string OriginalLang { get; set; }
    [Required] [MaxLength(2500)] public string TranslatedQuestMessage { get; set; }
    [Required] public string TranslationLang { get; set; }


    public QuestPlate(string questName, string originalQuestMessage, string originalLang,
      string translatedQuestMessage, string translationLang)
    {
      QuestName = questName;
      OriginalQuestMessage = originalQuestMessage;
      OriginalLang = originalLang;
      TranslatedQuestMessage = translatedQuestMessage;
      TranslationLang = translationLang;
    }
  }

}
