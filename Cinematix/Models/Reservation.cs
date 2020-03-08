namespace Cinematix.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MovieVenueId { get; set; }
        public string SeatNumber { get; set; }
        public double Price { get; set; }
    }
}
