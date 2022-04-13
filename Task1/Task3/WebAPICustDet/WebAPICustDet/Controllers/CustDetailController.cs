using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICustDet.Controllers
{
    public class Customer
    {
        public string cid { get; set; }
        public string cname { get; set; }
        public string caddr { get; set; }
        public long contactno { get; set; }
        public string cmailaddr { get; set; }

    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustDetailController : ControllerBase
    {
        List<Customer> Slist = new List<Customer>()
                {

                    new Customer() { cid = "C001", cname = "Sandeep", caddr = "Delhi", contactno=9763220934 ,cmailaddr="sandeep@gmail.com"},
                    new Customer() { cid ="C002" , cname = "Akshat", caddr = "Wardha", contactno =1235678902 ,cmailaddr="akshat@gmail.com"},
                    new Customer() { cid = "C003", cname = "sammy", caddr = "Ghorakpur", contactno =1728330433 ,cmailaddr="sammy@gmail.com"},
                    new Customer() { cid = "C004", cname = "Pradeep", caddr = "Wardha", contactno =1923839393 ,cmailaddr="pradeep@gmail.com"},
                    new Customer() { cid = "C005", cname = "Ram", caddr = "Pune", contactno =637288234,cmailaddr="ram@gmail.com"},
                    new Customer() { cid = "C006", cname = "Jayant", caddr = "Hinghanghat", contactno=2178288128,cmailaddr="jayant@gmail.com"},
                    new Customer() { cid = "C007", cname = "Kartik", caddr = "Nagpur", contactno =1739292872 ,cmailaddr="kartik@gmail.com"},
                    new Customer() { cid = "C008", cname = "Roy", caddr = "Mumbai", contactno =2827318278,cmailaddr="roy@gmail.com"},
                    new Customer() { cid = "C009", cname = "King", caddr = "Chennai", contactno =1729126426 ,cmailaddr="king@gmail.com"},
                    new Customer() { cid = "C0010", cname = "Prem", caddr = "Pune", contactno =1262164276,cmailaddr="prem@gmail.com"}
                };
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> getAllCust()
        {
            var res = from i in Slist select i;
            return res.ToList();
        }


    }
}
