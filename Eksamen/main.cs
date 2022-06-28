﻿// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Math;

public class main
{
    static void Main()
    {
        double[] x = new double[] { 0, 0.4, 0.8, 1.2, 1.6, 2.0, 2.4, 2.8, 3.2, 3.6, 4.0, 4.4, 4.8, 5.2, 5.6, 6.0, 6.4 };
        double[] y = new double[x.Length];
        double[] y_der = new double[x.Length];

        for (int i = 0; i <= x.Length - 1; i++)
        {
            y[i] = Sin(x[i]);
            WriteLine($"{x[i]} {y[i]}");
        }

        for (int i = 0; i <= x.Length - 2; i++)
        {
            y_der[i] = (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
        }

        WriteLine(y_der);
        WriteLine("\n");
        cspline c = new cspline(x, y, y_der);
        for (double z = x[0]; z <= x[x.Length - 1]; z += 1.0 / 256)
        {
            WriteLine($"{z} {c.eval(z)}");
        }
    }
}
