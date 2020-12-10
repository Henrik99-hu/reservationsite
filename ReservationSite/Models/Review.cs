using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string WrittenReview { get; set; }
        public float Score { get; set; }
        public Reservation Reservation { get; set; }

        public Review(string writtenReview, float score)
        {
            WrittenReview = writtenReview;
            Score = score;
        }
    }
}
