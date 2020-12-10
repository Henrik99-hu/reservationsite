using ReservationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Interfaces
{
    interface IUser
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; }
        public string PhoneNumber { get; set; }
        
    }
}
