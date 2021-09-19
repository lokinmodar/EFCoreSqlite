using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreSqlite.Models
{
  public class BaseEntity
  {
    [Timestamp] [Required] public DateTime CreatedDate { get; set; }
    [Timestamp] public DateTime UpdatedDate { get; set; }
  }
}