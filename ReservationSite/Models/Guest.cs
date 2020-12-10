using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationSite.Interfaces;

namespace ReservationSite.Models
{
    public class Guest
    {
        //FIELDS FOR COMPOSITE ATTRIBUTE
        private string _zip;
        private string _city;
        private string _street;
        private string _houseNumber;
        
        //NORMAL ATTRIBUTES
        public int GuestId { get; set; }
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

        //MAKING THE COMPOSITE ATTRIBUTE: ADRESS
        public string Zip
        {
            get { return _zip; }
            set
            {
                _zip = value;
                RefreshAdress();
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _zip = value;
                RefreshAdress();
            }
        }

        public string Street
        {
            get { return _street; }
            set
            {
                _zip = value;
                RefreshAdress();
            }
        }

        public string HouseNumber
        {
            get { return _houseNumber; }
            set
            {
                _zip = value;
                RefreshAdress();
            }
        }

        public string Adress { get; private set; }

        //PROPERTIES BECAUSE OF RELATIONSHIPS
        public List<Reservation> Reservations { get; set; }

        //CTOR
        public Guest(string name, string email, string password, string phoneNumber, string zip, string city, string street, string houseNumber)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Zip = zip;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }


        private void RefreshAdress()
        {
            Adress = _zip + " " + _city + ", " + _street + " " + _houseNumber;
        }


    }
}
