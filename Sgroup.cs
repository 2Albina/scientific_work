using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Sgroup
    {
        public Sgroup()
        {
            Teacher = new HashSet<Teacher>();
        }

        public int IdGroup { get; set; }
        public string Thematics { get; set; }
        public string NameMngr { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
