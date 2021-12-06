using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Models;

namespace GameStop_API.Services
{
    //Service is an element that provides the business logic for a part of the application
    public class ScaffoldingPeopleService : IPeopleService
    {
        //Singleton's implementation
        private static ScaffoldingPeopleService _instance;
        public static ScaffoldingPeopleService GetInstance()
        {
            if (_instance == null)
                _instance = new ScaffoldingPeopleService();
            return _instance;
        }

        private List<People> _person = new List<People>
        {
            new People
            {
                Id = 1, Name = "Blake", Age = 25
            },
            new People
            {
                Id = 2, Name = "Andrew", Age = 26
            },
            new People
            {
                Id = 3, Name = "Mina", Age = 19
            },
            new People
            {
                Id = 4, Name = "Josh", Age = 35
            },
        };

        private int _lastId = 5;
        public void AddPeople(People person)
        {
            person.Id = _lastId++;
            _person.Add(person);
        }
        public void DeletePeople(int id)
        {
            var indexOfPeople = _person.FindIndex(p => p.Id == id);
            if (indexOfPeople >= 0)
            {
                _person.RemoveAt(indexOfPeople);
            }
        }
        public List<People> GetAll()
        {
            return _person;
        }

        public People GetById(int id)
        {
            return _person.Where(p => p.Id == id).FirstOrDefault();
        }
        public void UpdatePerson(int id, People person)
        {
            var indexOfExisting = _person.FindIndex(p => p.Id == id);
            if (indexOfExisting >= 0)
            {
                person.Id = id;
                _person[indexOfExisting] = person;
            }
        }
        //
        public void UpdatePeople(int id, People person)
        {
            ((IPeopleService)_instance).UpdatePeople(id, person);
        }
    }
}
