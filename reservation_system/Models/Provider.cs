using System;
using System.Collections.Generic;

namespace reservation_system.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Criteria { get; set; }
        public string Discription { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}