using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class MovieRating
    {
        [Key]
        public Guid RatingId { get; set; }
        [ForeignKey("MovieId")]
        public Guid MovieId { get; set; }
        public int Score { get; set; }
    }
}
