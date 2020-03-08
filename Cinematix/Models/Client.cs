using System;
using System.Collections.Generic;

namespace Cinematix.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}