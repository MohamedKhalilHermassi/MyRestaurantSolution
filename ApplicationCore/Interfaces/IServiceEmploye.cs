using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceEmploye:IService<Employe>
    {
        public IEnumerable<Chef> MexicainRestaurant();
        public double SalairTotalServeur(Serveur serveur);
    }
}
