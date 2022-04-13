using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class Categorynew
    {
        public Categorynew()
        {
            Product = new HashSet<Product>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
