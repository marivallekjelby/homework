using static System.Console;
using static System.Math;
using System;
public class plaincspline
{
	public double[] x, y, b, c, d;
	public plaincspline(double[] x_spline, double[] y_spline, double[] y_derivative)
	{
		x = x_spline;
		y = y_spline;
		y_der = y_derivative;
		int n = x_spline.Length;
		// Should perhaps check if the lenghts of X and Y matches

		//double[] dx = new double[n - 1];
		//double[] dy = new double[n - 1];
		//double[] y_der = new double[n - 1];
		b_coef = new double[n];
		c_coef = new double[n - 1];
		d_coef = new double[n - 1];

		double[] B = new double[n];
		double[] D = new double[n];
		double[] Q = new double[n - 1];


		// Start by  defining dx and dy, and the derivative of y
		for (int i = 0; i < n - 1; i++)
		{
			dx[i] = x[i + 1] - x[i]; if (!(dx[i] > 0)) throw new Exception("linterp: dx[i]<0"); // Må denne lange greien her med (fra if)?
			//dy[i] = y[i + 1] - y[i];
			
		}

		
		
		D[0] = 2; // using 0 because that is i=1 
		

		for (int i = 0; i < n - 2; i++)
		{
			D[i + 1] = 2 * dx[i] / dx[i + 1] + 2;
		}



		D[n - 1] = 2;
		Q[0] = 1;


		for (int i = 0; i < n - 2; i++)
		{
			Q[i + 1] = dx[i] / dx[i + 1];
		}


		B[0]=3*y_der[0]
		B[n] = 3 * y_der[n - 1];


		for (int i = 0; i < n - 2; i++)
		{
			B[i + 1] = 3 * (y_der[i] + y_der[i + 1] * dx[i] / dx[i + 1]);
		}



		for (int i = 1; i < n; i++)
		{
			D[i] -= Q[i - 1] / D[i - 1];
			B[i] -= B[i - 1] / D[i - 1];
		}

		b[n - 1] = B[n - 1] / D[n - 1];


		for (int i = 0; i < n - 1; i++)
		{
			b[i] = (B[i] - Q[i] * b[i + 1]) / D[i];
		}


		// Now we have everything we need to find ci and di:

		for (int i = 0; i < n - 1; i++)
		{
			c[i] = (-2 * b[i] - b[i + 1] + 3 * y_der[i] / dx[i]);
			d[i] = (b[i] + b[i + 1] - 2 * y_der[i]) / dx[i] / dx[i];
		}

	}



	public double eval(double z)
	{
		int i = binsearch(x, z);
		double S = y[i] + (z - x[i]) * (b[i] + (z - x[i]) * (c[i] + (z - x[i]) * d[i]));
		return S;
	}

	public static int binsearch(double[] x, double z)
	{
		if (!(x[0] <= z && z <= x[x.Length - 1])) throw new Exception("binsearch: bad z");
		int i = 0, j = x.Length - 1;
		while (j - i > 1)
		{
			int mid = (i + j) / 2;
			if (z > x[mid]) i = mid; else j = mid;
		}
		return i;
	}	



	// Er dette nedenfor det som var ekstra? ser sånn ut jaaaa

	// Finding the derivative

	public double derivative(double z)
	{
		int i = binsearch(x, z);
		return b[i] + 2 * c[i] * (z - x[i]) + 3 * d[i] * (z - x[i]) * (z - x[i]);
	}


	public double integral(double z)
	{
		int n = binsearch(x, z);
		double integral = 0;
		for (int i = 0; i < n; i++)
		{
			integral += y[i] * (x[i + 1] - x[i]) + b[i] * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) / 2 + c[i] * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) / 3 + d[i] * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) * (x[i + 1] - x[i]) / 4;
		}
		integral += y[n] * (z - x[n]) + b[n] * (z - x[n]) * (z - x[n]) / 2 + c[n] * (z - x[n]) * (z - x[n]) * (z - x[n]) / 3 + d[n] * (z - x[n]) * (z - x[n]) * (z - x[n]) * (z - x[n]) / 4;
		return integral;
	}

	
}


// Kan kanskje droppe de over siden det er ekstra eller noe hun trengte siden hun ikke hadde den deriverte 






static void main() {


	// Er dette noenløsning?

	for (int i = 0; i < nInterpolate; i++)
	{
		xs[i] = (float)i / upsampleFactor;
	}

	// For perf, test multiple reps
	int reps = 100;
	DateTime start = DateTime.Now;

	for (int i = 0; i < reps; i++)
	{
		CubicSpline spline = new CubicSpline();
		float[] ys = spline.FitAndEval(x, y, xs, false);
	}

	TimeSpan duration = DateTime.Now - start;
	Console.WriteLine("CubicSpline upsample from {0:n0} to {1:n0} points took {2:0.00} ms for {3} iterations ({2:0.000} ms per iteration)",
		n, nInterpolate, duration.TotalMilliseconds, reps, duration.TotalMilliseconds / reps);

	double[] y_der;
	y_der = subspline.inner(x, y);
	for (int j = 0; j < y_der.Length; j++)
	{
		WriteLine($"{x[j]} {y[j]} {y_der[j]}");
	}




	CubicSpline naturalSpline = new CubicSpline(x, y, y_der);
	for (double k = 0; k < x[n - 1]; k += 0.1)
	{
		WriteLine($"{k} {spline.eval(k)} {spline.derivative(k)} {spline.integral(k)} {pqspline.eval(k)} {pcspline.eval(k)}");  // Skal jeg kanskje kun bruke de to siste her?
	}


	

	// Line with bump
	double[] x2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	double[] y2 = { 1, 1, 1, 1, 2, 4, 8, 4, 2, 1, 1 };
	for (int i = 0; i < x2.Length; i++)
	{
		WriteLine($"{x2[i]} {y2[i]}");
	}




	double[] p2 = subspline.inner(x2, y2);
	cspline spline2 = new cspline(x2, y2, p2);
	plainqspline pqspline2 = new plainqspline(x2, y2);
	plaincspline pcspline2 = new plaincspline(x2, y2);
	for (double k = 0; k < x2[x2.Length - 1]; k += 0.1)
	{
		WriteLine($"{k} {spline2.eval(k)} {spline2.derivative(k)} {spline2.integral(k)} {pqspline2.eval(k)} {pcspline2.eval(k)}");
	}

	WriteLine();
	WriteLine();

	// Line with jump
	double[] x3 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	double[] y3 = { 1, 1, 1, 1, 1, 6, 6, 6, 6, 6, 6 };
	for (int i = 0; i < x3.Length; i++)
	{
		WriteLine($"{x3[i]} {y3[i]}");
	}

	WriteLine();
	WriteLine();

	

}//class