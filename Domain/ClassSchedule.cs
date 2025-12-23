using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class ClassSchedule
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }

        public List<Teacher> Teachers { get; set; }

        public TimeSpan StartTime { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public GymClass GymClass { get; set; }


        }
}
