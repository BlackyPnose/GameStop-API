using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Models;
using GameStop_API.Services;
using Microsoft.AspNetCore.Http;

namespace GameStop_API.Controllers
{
        //To handle the HTTP calls 
        [Route("[controller]")] //to map the calls

        [ApiController] // to point that this class handles the resorces
    public class PeopleController : Controller
    {
        private IPeopleService _peopleService = ScaffoldingPeopleService.GetInstance();
        

        [HttpGet]
        public List<People> Get() // input
        {
            var res = _peopleService.GetAll();

            //output
            return res;
        }

        [HttpPost]
        public void AddNewPeople([FromBody] People person)
        {
            _peopleService.AddPeople(person);
        }

        [HttpDelete("{id}")]
        public void RemoveById([FromRoute] int id)
        {
            _peopleService.DeletePeople(id);
        }

        [HttpPut("{id}")]
        public void UpdatePeople([FromRoute] int id, [FromBody] People person)
        {
            _peopleService.UpdatePeople(id, person);
        }
    }
}

