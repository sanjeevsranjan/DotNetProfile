﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IUnitOfWork db;
        public ValuesController(IUnitOfWork _db)
        {
            db = _db;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
           return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.TeacherRepo.DeleteById(id);
        }
    }
}
