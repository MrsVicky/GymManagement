using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class MembreShipPlan
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MonthlyClasLimit { get; set; }
    }
}
