using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Category
    {
        public Category()
        {
            Student = new HashSet<Student>();
        }

        public string Name { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
