using System;
using static System.Console;
using static System.Math;

public class main
{
	public static void Main()
	{

		// Finding minimum of Rosenbrock's valley function: 

		Func<vector, double> f1 = x => (1 - x[0]) * (1 - x[0]) + 100 * (x[1] - x[0] * x[0]) * (x[1] - x[0] * x[0]);
		vector x1 = new double[2] { 0, 0 };
		double acc1 = 1e-5;


		WriteLine($"The start guess is ({x1[0]},{x1[1]})");
		vector result1 = Minimisation.QuasiNewton(f1, x1, acc1);
		WriteLine($"The minimum was found at ({result1[0]},{result1[1]})");
		WriteLine($"Here f(x,y) = {f1(result1)}");
		WriteLine("We see from wikipedia that there is one minimum at (1,1), for f(x,y)=0");

		WriteLine("\n-------------------------------------------");

		// Finding the minimum of the Himmelblau´s function
		WriteLine("Test function f(x,y)=(x^2+y-11)^2+(x+y^2-7)^2");

		Func<vector, double> f2 = x => Pow(x[0] * x[0] + x[1] - 11, 2) + Pow(x[0] + x[1] * x[1] - 7, 2);
		vector x2 = new double[2] { 1, 1 };
		vector result2 = mini.qnewton(f2, x2, acc1);
		WriteLine($"The start guess is ({x02[0]},{x02[1]})");
		WriteLine($"The minimum was found at ({result2[0]},{result2[1]})");
		WriteLine($"Here f(x,y) = {f2(result2)}");
		WriteLine("We see from wikipedia that there is one minimum at (3,2), for f(x,y)=0");

	}



}