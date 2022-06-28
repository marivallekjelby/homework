using static System.Math;
using System;
public class cspline
{
    public double[] x, y, y_der, b, c, d;

    public cspline(double[] x_user, double[] y_user, double[] y_der_user)
    {
        // Move user variables to global variables.
        x = x_user;
        y = y_user;
        y_der = y_der_user;
        int n = x.Length;

        // Coefficients
        b = new double[n];
        c = new double[n - 1];
        d = new double[n - 1];

        // Create h(which is dx in our case)
        double[] h = new double[n - 1];

        for (int i = 0; i < n - 1; i++)
        {
            h[i] = x[i + 1] - x[i];
        }

        double[] D = new double[n];
        double[] Q = new double[n - 1];
        double[] B = new double[n];
        // Replace the first value in the arrays with values as explained in the book
        D[0] = 2;
        Q[0] = 1;
        B[0] = 3 * y_der[0];
        // Replace the last value in array B and D with values as explained in the book
        B[n - 1] = 3 * y_der[n - 2];
        D[n - 1] = 2;
        for (int i = 0; i < n - 2; i++)
        {
            Q[i + 1] = h[i] / h[i + 1];
            D[i + 1] = 2 * (h[i] / h[i + 1]) + 2;
        }
        for (int i = 0; i < n - 2; i++)
        {
            B[i + 1] = 3 * (y_der[i] + y_der[i + 1] * h[i] / h[i + 1]);
        }
        for (int i = 1; i < n; i++)
        {
            D[i] = D[i] - (Q[i - 1] / D[i - 1]);
            B[i] = B[i] - (B[i - 1] / D[i - 1]);
        }
        b[n - 1] = B[n - 1] / D[n - 1];
        for (int i = n - 1; i >= n; i--)
        {
            b[i] = (B[i] - Q[i] * b[i + 1]);
        }
        for (int i = 0; i < n - 1; i++)
        {
            c[i] = (-2 * b[i] - b[i + 1] + 3 * y_der[i]) / h[i];
            d[i] = (b[i] + b[i + 1] - 2 * y_der[i]) / Pow(h[i], 2);
        }


        double[] S = new double[n];
        for (int i = 0; i < n - 1; i++)
        {
            S[i] = y[i] + b[i] * h[i];
        }
    }
    public double eval(double z)
    {

        int i = binsearch(z);
        double h = z - x[i];
        return y[i] + b[i] * h + c[i] * h * h + d[i] * h * h * h;
    }
    public int binsearch(double z)
    {
        if (!(x[0] <= z && z <= x[x.Length - 1]))
        {
            throw new Exception("binsearch: bad z");
        }
        int i = 0;
        int j = x.Length - 1;
        while (j - i > 1)
        {
            int mid = (i + j) / 2;
            if (z > x[mid]) i = mid; else j = mid;
        }
        return i;
    }
}

