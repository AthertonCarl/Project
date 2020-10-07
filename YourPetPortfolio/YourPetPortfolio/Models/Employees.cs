using System;
using System.Collections.Generic;

namespace YourPetPortfolio.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? Age { get; set; }
        public DateTime? StartDate { get; set; }
        public int? VolunteerId { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animals Animal { get; set; }
        public virtual Volunteers Volunteer { get; set; }
    }
}
