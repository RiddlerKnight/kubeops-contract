using System;

static int FiboN(int n)
{
    double phi = (Math.Sqrt(5) + 1) / 2;
    return (int)Math.Round( Math.Pow(phi, n) / Math.Sqrt(5) );
}

Console.WriteLine(FiboN(2));
Console.WriteLine(FiboN(9));
Console.WriteLine(FiboN(8));
Console.WriteLine(FiboN(5));