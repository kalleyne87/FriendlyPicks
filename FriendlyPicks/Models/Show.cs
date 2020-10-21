using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class Show
    {
        [Key]
        public Guid ShowId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public int Season { get; set; }
        [ForeignKey("UserId")]
        public Guid SubmittedBy { get; set; }
        public ICollection<ShowRating> ShowRatings { get; set; }
    }
}
