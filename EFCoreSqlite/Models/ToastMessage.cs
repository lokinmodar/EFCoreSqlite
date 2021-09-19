using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreSqlite.Models
{
  [Table("toastmessages")]
  public class ToastMessage : BaseEntity
  {
    [Key] public int Id { get; set; }
    [Required] [MaxLength(40)] public string ToastType { get; set; }
    [Required] [MaxLength(200)] public string OriginalToastMessage { get; set; }
    [Required] public string OriginalLang { get; set; }
    [MaxLength(200)] public string TranslatedToastMessage { get; set; }
    [Required] public string TranslationLang { get; set; }


    public ToastMessage(string toastType, string originalToastMessage, string originalLang,
      string translatedToastMessage, string translationLang)
    {
      ToastType = toastType;
      OriginalToastMessage = originalToastMessage;
      OriginalLang = originalLang;
      TranslatedToastMessage = translatedToastMessage;
      TranslationLang = translationLang;
    }
  }

}
