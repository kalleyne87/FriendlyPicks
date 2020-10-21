using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class PodcastRating
    {
        [Key]
        public Guid RatingId { get; set; }
        [ForeignKey("PodcastId")]
        public Guid PodcastId { get; set; }
        public int Score { get; set; }
    }
}
