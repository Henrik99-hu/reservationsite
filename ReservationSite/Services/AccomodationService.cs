using ReservationSite.DataAccessLayer;
using ReservationSite.Models;
using ReservationSite.Models.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Services
{
    public class AccomodationService
    {
        private readonly ReservationSiteContext _reservationSiteContext;


        public AccomodationService(ReservationSiteContext reservationSiteContext)
        {
            _reservationSiteContext = reservationSiteContext;
        }

        //METHOD FOR ACTION: GET ACCOMODATIONS - LIST ALL THE ACCOMODATIONS OUT WITHOUT FILTER
        public IEnumerable<Accomodation> ListAccomodations()
        {
            var accomodations = _reservationSiteContext.Accomodations;
            return accomodations.ToList();
        }

        public void AddAccomodation(AccomodationDto accomodationDto)
        {
            Accomodation accomodation = new Accomodation(accomodationDto.AccomodationName, accomodationDto.Type ,accomodationDto.Description, accomodationDto.OfferedCatering, accomodationDto.PrePayment, accomodationDto.CancellationFee, accomodationDto.AccomodationOwnerId);
            //accomodation.AccomodationOwner = _reservationSiteContext.AccomodationOwners.Find(accomodationDto.AccomodationOwnerId); //nem dob rá null exceptiont, de valamiért nullként adja hozzá ://
            //_reservationSiteContext.AccomodationOwners.Find(accomodationDto.AccomodationOwnerId).Accomodations.Add(accomodation); valamiért null exceptiont ad, még rá kell jönni, hogy miért és hogyan adható hozzá.
            _reservationSiteContext.Accomodations.Add(accomodation);
            _reservationSiteContext.SaveChanges();
        }

    }
}
