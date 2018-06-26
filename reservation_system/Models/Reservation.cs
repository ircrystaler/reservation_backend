using System;

namespace reservation_system.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Duration { get; set; }
        public int ProviderId { get; set; }
        public int UserId { get; set; }
    }
}