using static System.Console;
using static System.Math;
using static linterp;
class main
{

	public static void Main()
	{
		double[] x = new double[] { 0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
		double[] ys = new double[9];

		for (int i = 0; i < y.Length; i++) { y[i] = Sin(x[i]); }
		for (int i = 0; i < x.Length; i++)
		{
			WriteLine($"{x[i]} {y[i]}");
		}
		WriteLine("");
		WriteLine("");

		for (double z = 0; z <= 8.0; z += 1.0 / 80)
		{
			WriteLine($"{z} {matlib.linterp(x, y, z)} {matlib.linterpInteg(x, y, z)}");
		}

	}

}