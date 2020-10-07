using System;
using System.Collections.Generic;

namespace YourPetPortfolio.Models
{
    public partial class Volunteers
    {
        public Volunteers()
        {
            Employees = new HashSet<Employees>();
        }

        public int VolunteerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? Age { get; set; }
        public DateTime? StartDate { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animals Animal { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
