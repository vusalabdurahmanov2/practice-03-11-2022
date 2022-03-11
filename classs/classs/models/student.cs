using System;
using System.Collections.Generic;
using System.Text;


namespace classs.models
{
    class student:Person
    {
        public student()
        {
            name = "test";
        }
        public student(string name)
        {
            this.name=name;
        }
        public student(string name,string surname):this(name)
        {
            this.surname = surname;
        }
        public student(string name, string surname,int age):this(name,surname)
        {
            this.age = age;
        }

    }
}
