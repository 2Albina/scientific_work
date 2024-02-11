using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Teacher
    {
        public Teacher()
        {
            Student = new HashSet<Student>();
            TchrCnf = new HashSet<TchrCnf>();
            TchrPb = new HashSet<TchrPb>();
        }

        public int IdTchr { get; set; }
        public string NameTchr { get; set; }
        public int? IdGroup { get; set; }

        public virtual Sgroup IdGroupNavigation { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<TchrCnf> TchrCnf { get; set; }
        public virtual ICollection<TchrPb> TchrPb { get; set; }
    }
}
