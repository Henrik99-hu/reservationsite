using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models
{
    public class Accomodation
    {
        public int AccomodationId { get; set; }
        public string AccomodationName { get; set; }
        public bool IsActive { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string OfferedCatering { get; set; }
        public int PrePayment { get; set; }
        public int CancellationFee { get; set; }
        public int AccomodationOwnerId { get; set; }
        public AccomodationOwner AccomodationOwner { get; set; }
        public List<Room> Rooms { get; set; }

        public Accomodation(string accomodationName, string type, string description, string offeredCatering, int prePayment, int cancellationFee, int accomodationOwnerId)
        {
            AccomodationName = accomodationName;
            Type = type;
            Description = description;
            OfferedCatering = offeredCatering;
            PrePayment = prePayment;
            CancellationFee = cancellationFee;
            AccomodationOwnerId = accomodationOwnerId;
            IsActive = true;
        }
    }
}
