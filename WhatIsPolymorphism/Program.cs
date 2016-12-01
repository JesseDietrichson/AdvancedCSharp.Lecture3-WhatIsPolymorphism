using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsPolymorphism
{
    class Program
    {
        //Lecture 3: What is Polymorphism?
        static void Main(string[] args)
        {
            List<Person> emps = new List<Person>();

            Student s = new Student();
            s.Name = "Jesse";
            s.Age = 15;
            s.GradeLevel = 8;

            Employee e = new Employee();
            e.Name = "Bob";
            e.Age = 50;
            e.ID = "234234jdfjsdf";

            emps.Add(s);
            emps.Add(e);

            foreach (Person p in emps)
            {
                if (p is Student)
                {
                    Student temp = p as Student;
                    Console.WriteLine(temp.GradeLevel);
                }
                else if (p is Employee)
                {
                    Employee temp = p as Employee;
                    Console.WriteLine(temp.ID);
                }
            }

        }
    }
}
