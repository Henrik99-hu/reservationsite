using ReservationSite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models
{
    public class AccomodationOwner
    {
        public int AccomodationOwnerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        private string password;
        public string Password
        {
            get { return password; }
            //TODO: PASSWoRD HASHELÉS
            private set { password = value; }
        }
        public List<Accomodation> Accomodations { get; set; }

        public AccomodationOwner(string name, string email, string phoneNumber, string password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
