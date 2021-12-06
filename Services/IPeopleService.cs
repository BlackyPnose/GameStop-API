using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Models;

namespace GameStop_API.Services
{
    interface IPeopleService
    {
        List<People> GetAll();
        People GetById(int id);
        void AddPeople(People person);
        void UpdatePeople(int id, People person);
        void DeletePeople(int id);
    }
}
