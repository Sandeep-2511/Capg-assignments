using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class Coursedet
    {
        public Coursedet()
        {
            Studentdet = new HashSet<Studentdet>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cduration { get; set; }
        public decimal? Cfee { get; set; }

        public virtual ICollection<Studentdet> Studentdet { get; set; }
    }
}
