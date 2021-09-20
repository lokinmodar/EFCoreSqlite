// <copyright file="ToastMessage.cs" company="lokinmodar">
// Copyright (c) lokinmodar. All rights reserved.
// Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International Public License license.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSqlite.Models
{
  [Table("toastmessages")]
  public class ToastMessage
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(40)]
    public string ToastType { get; set; }

    [Required]
    [MaxLength(200)]
    public string OriginalToastMessage { get; set; }

    [Required]
    public string OriginalLang { get; set; }

    [MaxLength(200)]
    public string TranslatedToastMessage { get; set; }

    [Required]
    public string TranslationLang { get; set; }

    [Required]
    public int TranslationEngine { get; set; }

    [Timestamp]
    [Required]
    public DateTime CreatedDate { get; set; }

    [Timestamp]
    public DateTime UpdatedDate { get; set; }

    public ToastMessage(string toastType, string originalToastMessage, string originalLang,
      string translatedToastMessage, string translationLang, int translationEngine)
    {
      this.ToastType = toastType;
      this.OriginalToastMessage = originalToastMessage;
      this.OriginalLang = originalLang;
      this.TranslatedToastMessage = translatedToastMessage;
      this.TranslationLang = translationLang;
      this.TranslationEngine = translationEngine;
      this.CreatedDate = DateTime.Now;
    }

    public override string ToString()
    {
      return
        $"Id: {this.Id}, ToastType: {this.ToastType}, OriginalMsg: {this.OriginalToastMessage}, OriginalLang: {this.OriginalLang}, TranslMsg: {this.TranslatedToastMessage}, TransLang: {this.TranslationLang}, TranEngine: {this.TranslationEngine}, CreatedAt: {this.CreatedDate}, UpdatedAt: {this.UpdatedDate}";
    }
  }
}
