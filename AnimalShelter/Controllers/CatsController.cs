using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;


namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/cats
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
      return _db.Cats.ToList();
    }

    // GET api/cats/5
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    // POST api/cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    // PUT api/cats/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
        cat.CatId = id;
        _db.Entry(cat).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/cats/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}