using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum TypeRestaurant
    {
        Italien,Japonais,Mexicain
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string  Adresse { get; set; }
        public TypeRestaurant Type { get; set; }
        public virtual ICollection<Employe>  Employes { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
      

    }
}
