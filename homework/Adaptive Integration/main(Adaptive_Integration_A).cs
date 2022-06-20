using System;
using static System.Console;
using static System.Math;
using static integrate;
using System.IO;

class main
{
	public static void Main()
	{

		WriteLine($"Testing the implementation of some integrals");

		Func<double, double> f1 = x => Sqrt(x)
		Func<double, double> f2 = x => 1 / Sqrt(x)
		Func<double, double> f3 = x => 4 * Sqrt(1 - x * x)
		Func<double, double> f4 = x => Log(x) / Sqrt(x);

		WriteLine($"Integral of sqrt(x) from 0 to 1 = {Integrate(f1, 0, 1)} (Should be 2/3 = 0.666...)");
		WriteLine($"Integral of 1/sqrt(x) from 0 to 1 = {Integrate(f2, 0, 1)} (Should be 2)");
		WriteLine($"Integral of 4*sqrt(1-x*x) from 0 to 1 = {Integrate(f3, 0, 1)} (Should be pi = 3.14159...)");
		WriteLine($"Integral of ln(x)/sqrt(x) from 0 to 1 = {Integrate(f4, 0, 1)} (Should be -4)");

		Writeline("Estimating error function.")

		using (var outfile = new System.IO.StreamWriter("gamma.txt"))
		{
			for (double x = -3; x <= 3; x += 1.0 / 16)
			{
				outfile.WriteLine($"{x} {erf(x)}");
			}
		}
	}
}