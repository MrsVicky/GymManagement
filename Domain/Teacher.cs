using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Teacher
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }

        public string FullName { get; set; }

        public List<Specialty> Specialties { get; set; }

        public bool IsActive { get; set; }
    }
}
