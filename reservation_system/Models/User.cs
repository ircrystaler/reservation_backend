using System;
using System.Collections.Generic;

namespace reservation_system.Models
{
    public class User
    {
        public User()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public ICollection<Reservation> Reservations { get; set; }
    }
}