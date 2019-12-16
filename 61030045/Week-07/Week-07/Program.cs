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
            {
                Teacher teacher = new Teacher("Tom", 350f);
                Professor prof = new Professor("Jerry", 500f, 5000f);
                // teacher work 20Hr/month
                Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                    teacher.CalculateCharge(20f));
                // professor work 12Hr/month
                Console.WriteLine("{0} charge = {1}", prof.TypeName(),
                    prof.CalculateCharge(12F));
                Console.ReadLine();
            }

            Student su = new Student("Student Name", "12345678");
            try
            {
                // su.Name = "My name";
                su.GPA = 3.5f;
                Console.WriteLine("Student name : " + su.Name);
                Console.WriteLine("Student ID   : " + su.ID);
                Console.WriteLine("Student GPA  : " + su.GPA);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        private string name;
        private string id;
        private float gpa;

        public Student(string Name, string ID)
        {
            this.name = Name;   // assign auto variable to the field
            this.id = ID;
        }

        public string Name
        {
            get { return name; }
        }
        public string ID
        {
            get { return id; }
        }
        public float GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value > 0.0 && value <= 4.0)
                    gpa = value;
                else
                    throw (new Exception("Error!!!! invalid GPA"));
            }
        }
    }
}
class Teacher
{
    // constructor (for initial private/protected variables)
    public Teacher(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }
    // figure out the charge based on teacher's rate
    public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }
    // return the name of this type
    public string TypeName()
    {
        return ("Teacher");
    }
    private string name;
    protected float billingRate;
}
class Professor : Teacher
{
    private float emolument;  // เงินประจำตำแหน่ง

    public Professor(string name, float billingRate) : base(name, billingRate)
    {
    }

    public Professor(string name, float billingRate, float emolument)
    : this(name, billingRate)
    {
        this.emolument = emolument;
    }

    // new function, because it's different than the base version
    public new float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F; // minimum charge.
        return (hours * billingRate) + emolument;
    }
    // new function, because it's different than the base version
    public new string TypeName()
    {
        return ("Professor");
    }
}