using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FriendlyPicks.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Icon { get; set; }
        public int Score { get; set; }
        public int MovieSubmissions { get; set; }
        public int ShowSubmissions { get; set; }
        public int PodcastSubmissions { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Show> Shows { get; set; }
        public ICollection<Podcast> Podcasts { get; set; }
    }
}
