using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class Conference
    {
        public Conference()
        {
            StudCnf = new HashSet<StudCnf>();
            TchrCnf = new HashSet<TchrCnf>();
        }

        public int IdCnf { get; set; }
        public string NameCnf { get; set; }
        public string ThemeCnf { get; set; }
        public DateTime DateCnf { get; set; }

        public virtual ICollection<StudCnf> StudCnf { get; set; }
        public virtual ICollection<TchrCnf> TchrCnf { get; set; }
    }
}
