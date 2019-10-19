using System;
namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHi();
            Student s = new Student();
            s.SayHi();
            Person sp = new Student();
            sp.SayHi();
            Teacher t = new Teacher();
            t.SayHi();
            Person tp = new Teacher();
            tp.SayHi();
            Console.ReadKey();
        }
    }
}




 