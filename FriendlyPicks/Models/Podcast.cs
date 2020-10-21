using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendlyPicks.Models
{
    public class Podcast
    {
        [Key]
        public Guid PodcastId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        [ForeignKey("UserId")]
        public Guid SubmittedBy { get; set; }
        public ICollection<PodcastRating> PodcastRatings { get; set; }
    }
}
