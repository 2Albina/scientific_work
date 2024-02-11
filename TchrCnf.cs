using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class TchrCnf
    {
        public int IdTchr { get; set; }
        public int IdCnf { get; set; }

        public virtual Conference IdCnfNavigation { get; set; }
        public virtual Teacher IdTchrNavigation { get; set; }
    }
}
