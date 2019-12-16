using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            su.Name = "Maethaphon Changart";
            su.ID = "61030045";
            su.GPA = 2.5f;
            Console.WriteLine("Student name : " + su.Name);
            Console.WriteLine("Student ID   : " + su.ID);
            Console.WriteLine("Student GPA  : " + su.GPA);
            Console.ReadLine();
        }
    }
    class Student
    {
        private string name;
        private string id;
        private float gpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public float GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }

}
