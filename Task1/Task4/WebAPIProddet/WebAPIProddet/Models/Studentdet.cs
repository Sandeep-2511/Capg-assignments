using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class Studentdet
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Saddr { get; set; }
        public string Semailid { get; set; }
        public int? Cid { get; set; }

        public virtual Coursedet C { get; set; }
    }
}
