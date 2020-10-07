using System;
using System.Collections.Generic;

namespace YourPetPortfolio.Models
{
    public partial class Animals
    {
        public Animals()
        {
            Employees = new HashSet<Employees>();
            Volunteers = new HashSet<Volunteers>();
        }

        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public int? AnimalAge { get; set; }
        public string AnimalGender { get; set; }
        public string AnimalBreed { get; set; }
        public string AnimalTemporment { get; set; }
        public string AnimalDescription { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Volunteers> Volunteers { get; set; }
    }
}
