using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cSharpWebAP.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
      Database.ApplicationDbContext dbContext;

public ValuesController(Database.ApplicationDbContext dbContext)
{
this.dbContext = dbContext;
}
        // GET api/values
        [HttpGet]
        public IEnumerable<Entities.Test> Get()
  {
     System.Console.WriteLine("Hello, World!");
      return dbContext.TestRecords;
  }

        // GET api/values/5
        [HttpGet("{id}")]
        public Entities.Test Get(int id)
  {
       System.Console.WriteLine("Hello, !");
      return dbContext.TestRecords.Where(t => t.Id == id).FirstOrDefault();
  }

        // POST api/values
        [HttpPost]
        public Entities.Test Post([FromBody]Entities.Test value)
  {
      dbContext.TestRecords.Add(value);
      dbContext.SaveChanges();
      return value;
  }

        // PUT api/values/5
        public Entities.Test Put(int id, [FromBody]Entities.Test value)
  {
     System.Console.WriteLine(id);
      // var entity = dbContext.TestRecords.Where(t => t.Id == id).FirstOrDefault();
      // entity.Name = value.Name;
      // entity.Description = value.Description;
      // dbContext.SaveChanges();
      return value;
  }

        // DELETE api/values/5
        public Entities.Test Delete(int id)
  {
     System.Console.WriteLine("Hello, World!");
      var entity = dbContext.TestRecords.Where(t => t.Id == id).FirstOrDefault();
      dbContext.TestRecords.Remove(entity);
      dbContext.SaveChanges();
      return entity;
  }
    }
}
