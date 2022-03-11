using System;
using System.Collections.Generic;
using System.Text;

namespace classs.models
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;
        public void fullname()
        {
            Console.WriteLine($"{name}{surname}");
        }
        public void getinfo()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }

}
