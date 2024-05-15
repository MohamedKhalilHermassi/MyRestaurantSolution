using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceClient:IService<Client>
    {
        public IEnumerable<Reservation> ConfrimedReservation(Client c);
        public IEnumerable<Reservation> ResevationsList(Client c);
    }
}
