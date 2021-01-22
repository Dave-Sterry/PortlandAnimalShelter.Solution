using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Controller
{
    [ApiVersion("1.0")]
    [Route("api/Cats")]
    [ApiController]
    public class CatsV1Controller : ControllerBase
    {
        private AnimalShelterContext _db;

        public CatsV1Controller(AnimalShelterContext db)
        {
            _db = db;
        }

        //GET api/cats
        [HttpGet]
        public ActionResult <IEnumerable<Cat>> Get()
        {
            return _db.Cats.ToList();
        }
    }

    [ApiVersion("2.0")]
    [Route("api/{v:ApiVersion}/Cats")]
    [ApiController]
    public class CatsV2Controller : ControllerBase
    {
        private AnimalShelterContext _db;
        
        public CatsV2Controller(AnimalShelterContext db)
        {
            _db = db;
        }

        //GET api/cats
        [HttpGet]
        public ActionResult<IEnumerable<Cat>> Get(string name, int age)
        {
            var query = _db.Cats.AsQueryable();
            if (name !=null)
            {
                query = query.Where(entry=>entry.Name == name);
            }
            if (age != 0)
            {
                query = query.Where(entry => entry.Age == age);
            }
            return query.ToList();
        }

        //POST api/cats
        [HttpPost]
        public void Post([FromBody] Cat cat)
        {
            _db.Cats.Add(cat);
            _db.SaveChanges();
        }

        //GET api/cats/3
        [HttpGet("{id}")]
        public ActionResult<Cat> Get(int id)
        {
            return _db.Cats.FirstOrDefault(entry=>entry.CatId == id);
        }

        //PUT api/cats/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cat cat)
        {
            cat.CatId = id;
            _db.Entry(cat).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/cats/3
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var catToDelete = _db.Cats.FirstOrDefault(entry=> entry.CatId == id);
            _db.Cats.Remove(catToDelete);
            _db.SaveChanges();
        }

        //RANDOM api/cats/random
        [HttpGet]
        [Route("random")]
        public ActionResult <Cat> Random()
        {
            Random random = new Random();
            int randomCat = random.Next(_db.Cats.ToList().Count);
            return _db.Cats.FirstOrDefault(entry => entry.CatId == randomCat);
        }
    }
}