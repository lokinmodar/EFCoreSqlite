// <copyright file="QuestPlate.cs" company="lokinmodar">
// Copyright (c) lokinmodar. All rights reserved.
// Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International Public License license.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSqlite.Models.Journal
{
  [Table("questplates")]
  public class QuestPlate
  {
    [Key]
    public int Id { get; set; }

    [Required]

    public string QuestId { get; set; }

    [Required]
    [MaxLength(200)]
    public string QuestName { get; set; }

    [Required]
    [MaxLength(2500)]
    public string OriginalQuestMessage { get; set; }

    [Required]
    public string OriginalLang { get; set; }

    [Required]
    [MaxLength(200)]
    public string TranslatedQuestName { get; set; }

    [Required]
    [MaxLength(2500)]
    public string TranslatedQuestMessage { get; set; }

    [Required]
    public string TranslationLang { get; set; }

    [Required]
    public int TranslationEngine { get; set; }

    [Timestamp]
    [Required]
    public DateTime CreatedDate { get; set; }

    [Timestamp]
    public DateTime UpdatedDate { get; set; }

    public QuestPlate(string questName, string originalQuestMessage, string originalLang,
      string translatedQuestMessage, string translationLang, int translationEngine, string questId, string translatedQuestName)
    {
      this.QuestId = questId;
      this.QuestName = questName;
      this.OriginalQuestMessage = originalQuestMessage;
      this.OriginalLang = originalLang;
      this.TranslatedQuestMessage = translatedQuestMessage;
      this.TranslatedQuestName = translatedQuestName;
      this.TranslationLang = translationLang;
      this.TranslationEngine = translationEngine;
      this.CreatedDate = DateTime.Now;
    }

    public override string ToString()
    {
      return
        $"Id: {this.Id}, QuestName: {this.QuestName}, QuestID: {this.QuestId} OriginalMsg: {this.OriginalQuestMessage}, OriginalLang: {this.OriginalLang}, TranslQuestName: {this.TranslatedQuestName}, TranslMsg: {this.TranslatedQuestMessage}, TransLang: {this.TranslationLang}, TranEngine: {this.TranslationEngine}, CreatedAt: {this.CreatedDate}, UpdatedAt: {this.UpdatedDate}";
    }
  }
}
