using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceRestaurant : Service<Restaurant>, IServiceRestaurant
    {
        public ServiceRestaurant(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
