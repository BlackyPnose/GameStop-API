using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop_API.Models
{
    public class Book
    {

        public People Author { get; set; }

        public void Print()
        {
            System.Console.WriteLine("Print from bool");
        }
    }
}
