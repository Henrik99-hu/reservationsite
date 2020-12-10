using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public int Persons { get; set; }
        public int PricePerPerson { get; set; }
        public byte[] Image { get; set; }
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

        public Room(string roomName, string roomType, int persons, int pricePerPerson, byte[] image, int accomodationId)
        {
            RoomName = roomName;
            RoomType = roomType;
            Persons = persons;
            PricePerPerson = pricePerPerson;
            Image = image;
            AccomodationId = accomodationId;
        }
    }
}
