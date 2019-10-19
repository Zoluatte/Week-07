using System;
using Lab7;

internal class Person
{
    internal void SayHi()
    {
        throw new NotImplementedException();
    }

    public static implicit operator Person(Professor v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Person(Student v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Person(Teacher v)
    {
        throw new NotImplementedException();
    }
}