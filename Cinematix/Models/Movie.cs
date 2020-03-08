using System.Collections.Generic;

namespace Cinematix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int ImdbId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Description { get; set; }
        public string Runtime { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public string PegiRating { get; set; }

        public ICollection<MovieVenue> MovieVenues { get; set; }
    }
}