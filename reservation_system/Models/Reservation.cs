using System;

namespace reservation_system.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public String StartTime { get; set; }
        public String Duration { get; set; }
        public Provider Provider { get; set; }
        public int? UserId { get; set; }
    }
}