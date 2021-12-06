using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop_API.Models
{
    public class People
    {
        //usually, when we use a EntityModel class, there is merely a business logic
        //(e.s. there are no methods that will help with calculation)
        //usually they just reppresent a Type.
        // I NEED TO REMEMBER THE "separation of concerns": one element needs to have one specific purpose
        //the class People or Person needs to reppresent the model of a Person
        //no connection with db, no controller ... nothing else
        //a CONTROLLER must only execute operations of input/output; NO view..NO db

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
