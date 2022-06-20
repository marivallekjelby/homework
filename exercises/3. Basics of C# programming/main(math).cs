using static System.Console;
using static System.Math;

class math
{
	static void Main()
	{
		double sqrt2 = Sqrt(2.0);
		Write($"sqrt(2) = {sqrt2}\n");
		Write($"sqrt(2)*sqrt(2) = {sqrt2 * sqrt2} (should be equal 2)\n");

		double epi = Exp(PI);
		Write($"exp(pi) = {epi}\n");
		Write($"ln(exp(pi) = {Log(epi)} (should be equal pi)\n");

		double pie = Pow(PI, E);
		Write($"pi^e = {pie}\n");
		Write($"pow(pi^e, 1/e) = {Pow(pie, 1 / E)} (should be equal to pi)\n");
	}
}