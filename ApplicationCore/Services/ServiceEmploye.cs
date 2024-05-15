using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceEmploye : Service<Employe>, IServiceEmploye
    {
        public ServiceEmploye(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Chef> MexicainRestaurant()
        {
            return GetMany(e => e.Restaurant.Type==TypeRestaurant.Mexicain)
                .OfType<Chef>();
        }

        public double SalairTotalServeur(Serveur serveur)
        {
           double bonus = 0;
            if(serveur.Note>=3)
            {
                bonus = 0.3;
            }
            else
            {
                bonus = 0.15;
            }
            return (serveur.Salaire)+(serveur.Salaire*bonus);   

        }
    }
}
