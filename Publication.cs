using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Publication
    {
        public Publication()
        {
            StudPb = new HashSet<StudPb>();
            TchrPb = new HashSet<TchrPb>();
        }

        public int IdPb { get; set; }
        public string NamePb { get; set; }
        public string ThemePb { get; set; }
        public DateTime DatePb { get; set; }

        public virtual ICollection<StudPb> StudPb { get; set; }
        public virtual ICollection<TchrPb> TchrPb { get; set; }
    }
}
