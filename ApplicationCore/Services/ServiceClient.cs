﻿using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceClient : Service<Client>, IServiceClient
    {
        public ServiceClient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Reservation> ConfrimedReservation(Client c)
        {
            return c.Reservations.Where(r => r.StatutReservation == true);
        }

        public IEnumerable<Reservation> ResevationsList(Client c)
        {
            return(IEnumerable<Reservation>) c.Reservations.
                GroupBy(r => r.Restaurant.Type);
        }
    }
}
