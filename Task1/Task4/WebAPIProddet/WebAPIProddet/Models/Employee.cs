using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Edesig { get; set; }
        public decimal? Esal { get; set; }
        public int? Did { get; set; }
        public int? ReportingTo { get; set; }

        public virtual Dept D { get; set; }
    }
}
