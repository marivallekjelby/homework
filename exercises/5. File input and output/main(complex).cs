using static System.Console;
using static System.Math;
using static cmath;

public class main
{
	static void Main()
	{

		//Calculations 
		complex minus_one = -1;
		WriteLine($"sqrt(-1) = {sqrt(minus_one)}");
		WriteLine($"sqrt(i) = {sqrt(I)}");
		WriteLine($"exp(i) = {exp(I)}");
		WriteLine($"exp(i*pi) = {exp(I * PI)}");
		WriteLine($"i^i = {cmath.pow(I, I)}");
		WriteLine($"ln(i) = {log(I)}");
		WriteLine($"sin(i*pi) = {sin(I * PI)}");
		WriteLine($"sinh(i) = {sinh(I)}");
		WriteLine($"cosh(i) = {cosh(I)}");
	}
}
