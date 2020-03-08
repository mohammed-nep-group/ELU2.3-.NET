using System.Collections.Generic;

namespace Cinematix.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string HouseNumberSuffix { get; set; }
        public string PostalCode { get; set; }
        public string Place { get; set; }

        public ICollection<Venue> Venues { get; set; }
    }
}
