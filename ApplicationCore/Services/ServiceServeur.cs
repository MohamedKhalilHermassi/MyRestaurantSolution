using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceServeur : Service<Serveur>, IServiceServeur
    {
        public ServiceServeur(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
