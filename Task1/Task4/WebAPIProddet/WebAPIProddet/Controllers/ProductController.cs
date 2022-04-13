using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIProddet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProddet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<CustDet> Get()
        {
            db1Context cnt = new db1Context();
            return cnt.CustDet;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IEnumerable<CustDet> Get(int id)
        {
            db1Context cnt = new db1Context();
            var sql = from i in cnt.CustDet where i.Pcode == id select i;
            return sql;

        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] CustDet value)
        {
            db1Context cnt = new db1Context();
            cnt.CustDet.Add(value);
            cnt.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustDet value)
        {
            db1Context cnt = new db1Context();
            var det = cnt.CustDet.Find(id);
            if (det != null)
            {
                det.Pname = value.Pname;
                det.Unitprice = value.Unitprice;
                det.Category = value.Category;
                det.Pdesc = value.Pdesc;
                det.Stockinhand = value.Stockinhand;
                cnt.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db1Context cnt = new db1Context();
            var obj = cnt.CustDet.Find(id);
            cnt.CustDet.Remove(obj);
            cnt.SaveChanges();
        }
    }
}
