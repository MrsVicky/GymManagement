using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class GymClass
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public int Capacity { get; set; }
    }
}
