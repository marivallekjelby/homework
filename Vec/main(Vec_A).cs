using static System.Console;
using static vec;
class main
{

	static void Main()
	{
		vec u = new vec(100, 200, 300);
		u.print("u=");
		vec v = new vec(1, 2, 3);
		v.print("v=");
		(u + v).print($"u+v = ");
		(u - v).print($"u-v = ");
		(4 * v).print($"4*v = ");
		var w = 4 * u - v;
		w.print("w =");
	}

}