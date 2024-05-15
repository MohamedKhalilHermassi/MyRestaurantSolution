using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Employe
    {
        [Key]
        public string Cin { get; set; }
        public string Nom { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="l'adresse email n'est pas valide")]
        public string Email { get; set; }
        public string NumTel { get; set; }
        public double Salaire { get; set; }
        [ForeignKey("Restaurant")]

        public int RestaurantKey { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
