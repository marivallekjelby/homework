using System;
using static System.Console;
using static System.Math;

public class main
{
	public static void Main()
	{
		Writeline("------------------------------------------------")
		WriteLine("Testing the root finding implementation);



		Func < vector, vector > f1 = x => new vector(2 * x[0]);
		vector x01 = new double[1] { 0.5 };
		vector result1 = roots.newton(f1, x01);
		WriteLine($"Finding the extremum of f1 at x = {result1[0]}");
		WriteLine("The analytical result is 0");


		Func<vector, vector> f2 = x => new vector(Pow(x[0] - 5, 2), Pow(x[1] - 5, 2));
		vector x02 = new double[2] { 0.5, 0.5 };
		vector result2 = roots.newton(f2, x02);
		WriteLine($"Finding the extremum of f2 at x = {result2[0]}");
		WriteLine("The analytical result is (5,5)");


		Func<vector, vector> f3 = x => new vector((-2 * (1 - x[0]) - 2 * x[0] * 200 * (x[1] - x[0] * x[0])), (200 * (x[1] - x[0] * x[0])));
		vector x03 = new double[2] { 0.5, 0.5 };
		vector result3 = roots.newton(f3, x03);
		WriteLine($"Finding the extremum of f3 at x = {result3[0]}");
		WriteLine("The analytical result is (1,1)");

		Writeline("-----------------------------------------------")


	}

}