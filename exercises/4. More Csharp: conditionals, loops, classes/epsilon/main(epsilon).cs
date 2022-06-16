// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using static System.Console;
using static System.Math;

public static class main
{
	// Maximum representable integer
	static void MaxInt()
	{
		int i = 1;
		while (i + 1 > i) { i++; }
		WriteLine($"my max int = {i} should be equal to {int.MaxValue}\n");
	}
	// Minimum representable integer
	static void MinInt()
	{
		int i = 1;
		while (i - 1 < i) { i--; }
		WriteLine($"my min int = {i} should be equal {int.MinValue}\n");
	}

	static void MachEpsilon()
	{
		// For double:
		double x = 1;
		while (1 + x != 1) { x /= 2; }
		x *= 2;
		WriteLine($"The machine epsilon for double: {x}");
		WriteLine($"It must be about {Pow(2, -52)}");

		// For float:
		float y = 1F;
		while ((float)(1F + y) != 1F) { y /= 2F; }
		y *= 2F;
		WriteLine($"The machine epsilon for float: {y}");
		WriteLine($"It must be about {Pow(2, -23)}"); ;
	}

	// Calculating sums
	static void Tiny()
	{
		int n = (int)1e6;
		double epsilon = Pow(2, -52);
		double tiny = epsilon / 2;
		double sumA = 0, sumB = 0;


		sumA += 1;
		for (int k = 0; k < n; k++)
		{
			sumA += tiny;
			sumB += tiny;
		}
		sumB += 1;

		sumA += 1; for (int i = 0; i < n; i++) { sumA += tiny; }
		WriteLine($"sumA-1 = {sumA - 1:e} should be {n * tiny:e}");

		for (int i = 0; i < n; i++) { sumB += tiny; }
		sumB += 1;
		WriteLine($"sumB-1 = {sumB - 1:e} should be {n * tiny:e}");

	}




	static bool approx(double a, double b, double tau = 1e-9, double epsilon = 1e-9)
	{
		//WriteLine($"Abs(a-b): {Abs(a-b)}");
		//	WriteLine($"(Abs(a-b)/(Abs(a)+Abs(b))): {(Abs(a-b)/(Abs(a)+Abs(b)))}");
		return (Abs(a - b) < tau) || (Abs(a - b) / (Abs(a) + Abs(b)) < epsilon);
	}

	//static void testapprox(){
	//	double a = 1;
	//	double b = a - 1e-9;
	//	WriteLine($"approx(1, 1+1e-9) = {approx(a,b)} should be True");

	//	b = 2;
	//		WriteLine($"approx(1, 2) = {approx(a, b)} should be False");

	//}

	static void Main()
	{
		MaxInt();
		MinInt();
		MachEpsilon();
		Tiny();
		WriteLine($"");
		Write($"Testing approx function...");
		Write($"a = 1.0, b = 2.0 should return false, does return: {approx(1.0, 2.0)}\n");
		Write($"a = 1.0, b = 1.0 should return true, does return: {approx(1.0, 1.0)}\n");

	}
}
