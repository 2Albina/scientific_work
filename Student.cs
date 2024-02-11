using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Student
    {
        public Student()
        {
            StudCnf = new HashSet<StudCnf>();
            StudPb = new HashSet<StudPb>();
        }

        public int IdStud { get; set; }
        public string NameStud { get; set; }
        public string Status { get; set; }
        public int Course { get; set; }
        public int? IdTchr { get; set; }
        public string Category { get; set; }
        public int Yr { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual Teacher IdTchrNavigation { get; set; }
        public virtual ICollection<StudCnf> StudCnf { get; set; }
        public virtual ICollection<StudPb> StudPb { get; set; }
    }
}
