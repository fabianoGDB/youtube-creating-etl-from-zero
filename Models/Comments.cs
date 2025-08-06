using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace youtube_etl_do_zero.Models
{
    public class Comments
    {
        [JsonPropertyName("postId")]
        public long PostId { get; set; }

        [Key]
        [JsonPropertyName("userId")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}