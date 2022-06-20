using System;
using static System.Console;
using static System.Math;
using static System.Double;
class main
{

	public static void Main()
	{
		int i = 0;
		int j = 0;
		int k = 0;
		int l = 0;
		double a = 0.0;
		double b = 1.0;

		Func<double, double> f1 = x => { i++; return 1 / Sqrt(x); };

		Func<double, double> f2 = x => { j++; return 1 / Sqrt(x); };

		Func<double, double> f3 = x => { k++; return Log(x) / Sqrt(x); };

		Func<double, double> f4 = x => { l++; return Log(x) / Sqrt(x); };

		double result1 = integrator.integrate(f1, a, b);
		double result2 = integrator.integrate(f2, a, b);
		double result3 = integrator.integrate(f3, a, b);
		double result4 = integrator.integrate(f4, a, b);

		Writeline("--------------------------------------------------")
		WriteLine($"Comparison of number of evaluations");


		WriteLine($"In the integral from {a} to {b} of 1/Sqrt(x) = {result1}, the number of evaluations was {i}");
		WriteLine($"In the Clenshaw-Curtis method = {result2}, the number of evaluations was {j}");
		WriteLine($"In the integral from {a} to {b} of Log(x)/Sqrt(x) = {result3}, the number of evaluations was {k}");
		WriteLine($"Clenshaw-Curtis method = {result4}, the number of evaluations was {l}");
	}

}