using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pdesc { get; set; }
        public int? Cid { get; set; }
        public decimal? Pprice { get; set; }

        public virtual Categorynew C { get; set; }
    }
}
