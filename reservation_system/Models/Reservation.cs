using System;

namespace reservation_system.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public String Day { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public Provider Provider { get; set; }
        public int? UserId { get; set; }
    }
}