using System;

internal class Teacher
{
    private string v1;
    private float v2;

    public Teacher(string v1, float v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Teacher()
    {
    }

    internal int TypeName()
    {
        throw new NotImplementedException();
    }

    internal int CalculateCharge(float v)
    {
        throw new NotImplementedException();
    }

    internal void SayHi()
    {
        throw new NotImplementedException();
    }
}