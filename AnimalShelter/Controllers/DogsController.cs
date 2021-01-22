using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Controller
{
    [ApiVersion("1.0")]
    [Route("api/Dogs")]
    [ApiController]
    public class DogsV1Controller : ControllerBase
    {
        private AnimalShelterContext _db;

        public DogsV1Controller(AnimalShelterContext db)
        {
            _db = db;
        }

        //GET api/dogs
        [HttpGet]
        public ActionResult <IEnumerable<Dog>> Get()
        {
            return _db.Dogs.ToList();
        }
    }

    [ApiVersion("2.0")]
    [Route("api/{v:ApiVersion}/Dogs")]
    [ApiController]
    public class DogsV2Controller : ControllerBase
    {
        private AnimalShelterContext _db;

        public DogsV2Controller(AnimalShelterContext db)
        {
            _db = db;
        }

        //GET api/2.0/dogs
        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get(string name, int age)
        {
            var query = _db.Dogs.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if(age != 0)
            {
                query = query.Where(entry => entry.Age == age);
            }
            return query.ToList();
        }

        //POST api/2.0/dogs
        [HttpPost]
        public void Post([FromBody] Dog dog)
        {
            _db.Dogs.Add(dog);
            _db.SaveChanges();
        }

        //PUT api/2.0/dogs/2
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dog dog )
        {
            dog.DogId = id;
            _db.Entry(dog).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/2.0/dogs/2
        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId ==id);
            _db.Dogs.Remove(dogToDelete);
            _db.SaveChanges();
        }

        //RANDOM api/2.0/dogs/random
        [HttpGet]
        [Route("random")]
        public ActionResult <Dog> Random()
        {
            Random random = new Random();
            int randomDog = random.Next(_db.Dogs.ToList().Count);
            return _db.Dogs.FirstOrDefault(entry => entry.DogId == randomDog);
        }
    }
}