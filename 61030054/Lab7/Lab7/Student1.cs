using System;

namespace Lab7
{
    internal class Student
    {
        public string Name { get; internal set; }
        public string ID { get; internal set; }
        public float GPA { get; internal set; }

        internal void SayHi()
        {
            throw new NotImplementedException();
        }
    }
}