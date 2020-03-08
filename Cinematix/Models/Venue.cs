using System.Collections.Generic;

namespace Cinematix.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Note { get; set; }
        public string SpecialArragement { get; set; }

        public ICollection<MovieVenue> MovieVenues { get; set; }
    }
}
