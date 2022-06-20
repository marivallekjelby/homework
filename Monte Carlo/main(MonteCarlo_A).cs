using System;
using static System.Console;
using static System.Math;

public class main
{
	public static void Main()
	{
		Writeline("-------------------------------------------------------------------");
		WriteLine($"Testing the implementation of Monte Carlo integration:");

		WriteLine($"\n");

		WriteLine($"Integration of x*y dx dy, x = [0,1] and y = [0,1]:");

		Func<vector, double> f1 = x => x[0] * x[1];
		vector a1 = new double[2] { 0, 0 };
		vector b1 = new double[2] { 1, 1 };
		var result1 = mcint.plainmc(f1, a1, b1, 50000);
		WriteLine($"The result is {result1.Item1} and the error is {result1.Item2}");
		WriteLine($"The result should be 0.25");


		WriteLine($"Integration of x*sin(y) dx dy, with x = [0,1] and y=[0,pi]:");
		Func<vector, double> f2 = x => x[0] * Sin(x[1]);
		vector a2 = new double[2] { 0, 0 };
		vector b2 = new double[2] { 1, PI };
		var result2 = mcint.plainmc(f2, a2, b2, 50000);
		WriteLine($"The result is {result2.Item1} and the error is {result2.Item2});
		WriteLine($"The result should be 1");


		WriteLine($"Integration of 1/(1-cos(x)*cos(y)*cos(z)*pi^3) dx dy dz, x = [0,pi], y = [0,pi] and z = [0,pi]:");
		Func<vector, double> f3 = x => 1 / ((1 - Cos(x[0]) * Cos(x[1]) * Cos(x[2])) * Pow(PI, 3));
		vector a3 = new double[3] { 0, 0, 0 };
		vector b3 = new double[3] { PI, PI, PI };
		var result3 = mcint.plainmc(f3, a3, b3, 50000);
		WriteLine($"The result is {result3.Item1} and the error is {result3.Item2}");
		WriteLine($"The result should be 1.3932039");
	}

}