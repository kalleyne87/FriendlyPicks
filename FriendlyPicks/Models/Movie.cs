using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        [ForeignKey("UserId")]
        public Guid SubmittedBy { get; set; }
        public ICollection<MovieRating> MovieRatings { get; set; }
    }
}
    