using ReservationSite.DataAccessLayer;
using ReservationSite.Models;
using ReservationSite.Models.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Services
{
    public class AccomodationOwnerService
    {
        private readonly ReservationSiteContext _reservationSiteContext;

        public AccomodationOwnerService(ReservationSiteContext reservationSiteContext)
        {
            _reservationSiteContext = reservationSiteContext;
        }

        public IEnumerable<AccomodationOwner> ListAccomodationOwners()
        {
            var accomodationOwners = _reservationSiteContext.AccomodationOwners;
            return accomodationOwners.ToList();
        }

        public async Task<IEnumerable<AccomodationOwner>> AddAccomodationOwner(AccomodationOwnerDto accomodationOwnerDto)
        {
            await _reservationSiteContext.AccomodationOwners.AddAsync(new AccomodationOwner(accomodationOwnerDto.Name, accomodationOwnerDto.Email, accomodationOwnerDto.PhoneNumber, accomodationOwnerDto.Password));
            _reservationSiteContext.SaveChanges();
            var accomodationOwners = _reservationSiteContext.AccomodationOwners;
            return accomodationOwners.ToList();
        }
    }
}
