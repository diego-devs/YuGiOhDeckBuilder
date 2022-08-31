﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace YugiohDB.Models
{ 
    public partial class Card
    {
        // key just for testing.Delete this as foreign key in SQL and delete this property
        [Key]
        [JsonPropertyName("InternalCardID")]
        public int InternalCardID {get;set;}

        [JsonPropertyName("id")]
        public int CardId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        [JsonPropertyName("atk")]
        public long Atk { get; set; }

        [JsonPropertyName("def")]
        public long Def { get; set; }

        [JsonPropertyName("level")]
        public long Level { get; set; }

        [JsonPropertyName("race")]
        public string Race { get; set; }

        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }

        [JsonPropertyName("archetype")]
        public string Archetype { get; set; }

        [JsonPropertyName("scale")]
        public int Scale { get; set; }
        [JsonPropertyName("linkval")]
        public int LinkVal { get; set; }
        [JsonPropertyName("linkmarkers")]
        public List<string> LinkMarkers { get; set; }

        [JsonPropertyName("card_sets")]
        public List<CardSet> CardSets { get; set; }

        [JsonPropertyName("card_images")]
        public List<Image> CardImages { get; set; }

        [JsonPropertyName("card_prices")]
        public List<Price> CardPrices { get; set; }

        [JsonPropertyName("data")]
        public List<Card> Data { get; set; }
    }


    
    
}
