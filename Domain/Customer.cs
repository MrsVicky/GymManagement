using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Customer : User
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }

        public MembreShipPlan MembreShipPlan { get; set; }
    }
}
