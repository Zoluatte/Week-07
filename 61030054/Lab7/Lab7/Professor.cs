using System;

internal class Professor
{
    private string v1;
    private float v2;
    private float v3;

    public Professor()
    {
    }

    public Professor(string v1, float v2, float v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    internal int CalculateCharge(float v)
    {
        throw new NotImplementedException();
    }

    internal int TypeName()
    {
        throw new NotImplementedException();
    }
}