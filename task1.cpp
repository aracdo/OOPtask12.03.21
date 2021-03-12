using System;
using System.Collections.Generic;

namespace OOPtest
{
    
    class Student
    {
        private protected string firstName;
        private protected string lastName;
        private protected string group;
        private protected double averageMark;

        public Student(string firstName,  string lastName, string group, double averageMark)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.group = group;
            this.averageMark = averageMark;
        }
        public virtual int getScholarship()
        {
            if (this.averageMark == 5) return 100;
            return 80;
        }
    }
    class Asperant: Student
    {
        public Asperant(string firstName, string lastName, string group, double averageMark) : base (firstName, lastName, group, averageMark)
        {

        }
        public override int getScholarship()
        {
            if (this.averageMark == 5) return 200;
            return 180;
        }
    }

        
    class Program
    {
        static void Main(string[] args)
        {
            Student task1 = new Asperant("Ahmed","Muhamed","inf",4.3);

            List<Student> task2 = new List<Student>();
            task2.Add(new Asperant("sasa", "sasas", "sas", 2));
            task2.Add(new Student("sssa", "sffas", "sas", 5));
            task2.Add(new Asperant("sayysa", "sffas", "sas", 5));
            

           for (int i = 0; i< task2.Count; i++)
            {
                Console.WriteLine(task2[i].getScholarship());
            }

        }
    }
}   
