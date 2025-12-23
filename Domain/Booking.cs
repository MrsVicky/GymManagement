using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Booking
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }
        public Customer Customer { get; set; }
        public ClassSchedule ClassSchedule { get; set; }
        public DateTime BookingDate { get; set; }

        public Status Status { get; set; }


    }
}
