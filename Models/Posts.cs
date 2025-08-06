using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace youtube_etl_do_zero.Models
{
    public class Posts
    {
        [Key]
        [JsonPropertyName("userId")]
        public long UserId { get; set; }
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("body")]
        public string? Body { get; set; }

    }
}