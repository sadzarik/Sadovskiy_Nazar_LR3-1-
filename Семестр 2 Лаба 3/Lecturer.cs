using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3
{
    class Lecturer : Person
    {
        public bool CheckingHomeworks;
        public Lecturer() { }
        public Lecturer(string FirstName,string SecondName, string LastName,int Age, bool CheckingHomeworks): base(FirstName, SecondName, LastName, Age)
        {
            this.CheckingHomeworks = CheckingHomeworks;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName} , Age: {Age} , ");
            if (CheckingHomeworks == true)
            {
                Console.Write("is checking homeworks.");
            }
            if (CheckingHomeworks == false)
            {
                Console.Write("is not checking homeworks.");
            }
        }
        public void GetCheckingHomeworks()
        {
            if (CheckingHomeworks == true)
            {
                Console.WriteLine("Is checking homeworks.");
            }
            if (CheckingHomeworks == false)
            {
                Console.WriteLine("Is not checking homeworks.");
            }
        }
        public void GetAge()
        {
            Console.WriteLine("Age: " + Age);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;

            }
            Lecturer lecturer = obj as Lecturer;
            if (lecturer == null)
            {
                return false;
            }
            return lecturer.FirstName == this.FirstName &&
                lecturer.SecondName == this.SecondName &&
                lecturer.LastName == this.LastName &&
                lecturer.Age == this.Age &&
                lecturer.CheckingHomeworks == this.CheckingHomeworks;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.SecondName + " " + this.LastName + " Is checking homeworks:" + this.CheckingHomeworks + " Age:" + this.Age;
        }
    }
}
