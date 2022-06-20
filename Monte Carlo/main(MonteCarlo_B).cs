using System;
using static System.Console;
using static System.Math;
public class main
{

	public static void Main()
	{
		WriteLine("-----------------------------------------------------------------------");


		WriteLine("Integrating x*y dx dy, x = [0,1], y = [0,1]");
		Func<vector, double> f1 = x => x[0] * x[1];
		vector a1 = new double[2] { 0, 0 };
		vector b1 = new double[2] { 1, 1 };
		var result1_plain = mcint.plainmc(f1, a1, b1, 50000);
		var result1_halton = mcint.haltonmc(f1, a1, b1, 50000);
		WriteLine($"\tThe result of the plain routine is: {result1_plain.Item1} with the error {res1_plain.Item2}");
		WriteLine($"\tThe result of the Halton routine is: {res1_halton.Item1} with the error {res1_halton.Item2}");
		WriteLine("\tThe result should be 0.25");

		WriteLine("\nIntegrating (x + sin(y) + 1) dx dy, x = [0,1], y = [0,pi]");
		Func<vector, double> f2 = x => x[0] + Sin(x[1]);
		vector a2 = new double[2] { 0, 0 };
		vector b2 = new double[2] { 1, PI };
		var result2_plain = mcint.plainmc(f2, a2, b2, 50000);
		var result2_halton = mcint.haltonmc(f2, a2, b2, 50000);

		WriteLine($"\tThe result of the plain routine is: {result2_plain.Item1} with the error {res2_plain.Item2}");
		WriteLine($"\tThe result  of the Halton routine is: {res2_halton.Item1} with the error {res2_halton.Item2}");
		WriteLine("\tThe result should be 8*pi = 25.13");

		WriteLine("\nIntegrating 1/([1 - cos(x)*cos(y)*cos(z)]*pi^3) dx dy dz, x = [0,pi], y = [0,pi], z = [0,pi]");
		Func<vector, double> f3 = x => 1 / ((1 - Cos(x[0]) * Cos(x[1]) * Cos(x[2])) * Pow(PI, 3));
		vector a3 = new double[3] { 0, 0, 0 };
		vector b3 = new double[3] { PI, PI, PI };
		var result3_plain = mcint.plainmc(f3, a3, b3, 50000);
		var res3_halton = mcint.haltonmc(f3, a3, b3, 50000);
		WriteLine($"\tThe result of the plain routine is: {res3_plain.Item1} with the error {res3_plain.Item2}");
		WriteLine($"\tThe result of the Halton routine is: {res3_halton.Item1} with the error {res3_halton.Item2}");
		WriteLine("\tThe result should be 1.393203");

	}

}