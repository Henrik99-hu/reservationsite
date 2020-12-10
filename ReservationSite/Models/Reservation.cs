using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public bool IsActive { get; set; }
        public string Catering { get; set; }
        public int TotalValue { get; set; }
        public int PrePayment { get; set; }
        public int CancellationFee { get; set; }
        public string RoomType { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }

        public Reservation(DateTime arrival, DateTime departure, string catering, int totalValue, int prePayment, int cancellationFee, string roomType, int guestId, int accomodationId, int reviewId)
        {
            Arrival = arrival;
            Departure = departure;
            Catering = catering;
            TotalValue = totalValue;
            PrePayment = prePayment;
            CancellationFee = cancellationFee;
            RoomType = roomType;
            GuestId = guestId;
            AccomodationId = accomodationId;
            ReviewId = reviewId;
            IsActive = true;
        }

    }
}
