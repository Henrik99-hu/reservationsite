using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models.Data_Transfer_Objects
{
    public class AccomodationDto
    {
        public string AccomodationName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string OfferedCatering { get; set; }
        public int PrePayment { get; set; }
        public int CancellationFee { get; set; }
        public int AccomodationOwnerId { get; set; }

        public AccomodationDto(string accomodationName, string type, string description, string offeredCatering, int prePayment, int cancellationFee, int accomodationOwnerId)
        {
            AccomodationName = accomodationName;
            Type = type;
            Description = description;
            OfferedCatering = offeredCatering;
            PrePayment = prePayment;
            CancellationFee = cancellationFee;
            AccomodationOwnerId = accomodationOwnerId;
        }
    }
}
