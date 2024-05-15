using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Serveur:Employe
    {
        [Range(0,5)]
        public int Note { get; set; }
    }
}
