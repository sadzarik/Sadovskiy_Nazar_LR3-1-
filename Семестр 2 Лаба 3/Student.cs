using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3
{
    class Student : Person
    {
        public int Course;
        public bool Presence;
        public Student() { }
        public Student(string FirstName, string SecondName, string LastName, int Age, int Course, bool Presence) : base(FirstName, SecondName, LastName, Age)
        {
            this.Course = Course;
            this.Presence = Presence;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName} , Age: {Age} , Presence in lecture room: ");
            if (Presence == true)
            {
                Console.Write("present.");
            }
            if (Presence == false)
            {
                Console.Write("absent.");
            }
        }
        public void GetCourse()
        {
            Console.WriteLine($"Course: " + Course);
        }
        public void GetPresence()
        {
            if (Presence == true)
            {
                Console.WriteLine("Student is present.");
            }
            if (Presence == false)
            {
                Console.WriteLine("Student is absent.");
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
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            return student.FirstName == this.FirstName &&
                student.SecondName == this.SecondName &&
                student.LastName == this.LastName &&
                student.Age == this.Age &&
                student.Presence == this.Presence &&
                student.Course == this.Course;

        }
        public override string ToString()
        {
            return this.FirstName + " " + this.SecondName + " " + this.LastName + " Is present:" + this.Presence + " course:" + this.Course + " Age:" + this.Age;
        }
    }
}
