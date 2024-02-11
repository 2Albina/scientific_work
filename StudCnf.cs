using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class StudCnf
    {
        public int IdStud { get; set; }
        public int IdCnf { get; set; }

        public virtual Conference IdCnfNavigation { get; set; }
        public virtual Student IdStudNavigation { get; set; }
    }
}
