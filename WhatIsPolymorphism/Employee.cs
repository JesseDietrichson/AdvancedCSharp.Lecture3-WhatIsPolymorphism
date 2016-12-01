using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsPolymorphism
{
    class Employee : Person
    {
        public string ID { get; set; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and my id is {ID}");
        }
    }
}
