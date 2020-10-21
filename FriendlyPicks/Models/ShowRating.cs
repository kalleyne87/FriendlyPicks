using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class ShowRating
    {
        [Key]
        public Guid RatingId { get; set; }
        [ForeignKey("ShowId")]
        public Guid ShowId { get; set; }
        public int Score { get; set; }
    }
}
