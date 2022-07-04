using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(string FirstName,string SecondName, string LastName,int Age)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName} , Age: {Age}");
        }
        public override bool Equals(object? obj)
        {
            if (obj==null)
            {
                return false;

            }
            Person p = obj as Person;
            if (p == null)
            {
                return false;
            }
            return p.FirstName==this.FirstName && 
                p.SecondName==this.SecondName && 
                p.LastName==this.LastName && 
                p.Age == this.Age;
        }
        public override string ToString()
        {
            return this.FirstName+" "+this.SecondName+" "+this.LastName+" Age:"+this.Age;
        }
    }
}
