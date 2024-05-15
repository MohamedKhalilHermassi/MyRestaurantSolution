using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime Date { get; set; }
        public int Table { get; set; }
        public bool StatutReservation { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantFk { get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }
        public virtual  Restaurant Restaurant { get; set; }

        public virtual Client Client { get; set; }
    }
}
