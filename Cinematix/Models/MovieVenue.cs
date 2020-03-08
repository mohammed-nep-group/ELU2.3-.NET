using System;
using System.Collections.Generic;

namespace Cinematix.Models
{
    public class MovieVenue
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int VenueId { get; set; }
        public DateTime DateTime { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
