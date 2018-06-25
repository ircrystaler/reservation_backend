using System;

namespace reservation_system.Models
{
    public class User
    {
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string FamilyName {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
    }
}