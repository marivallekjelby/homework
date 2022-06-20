using static System.Console;
using static vec;
class main
{

	static void Main()
	{
		vec u = new vec(1, 2, 3);
		u.print("u =");
		vec v = new vec(4, 5, 6);
		u.print("v =");
		(u + v).print($"u+v =");
		var w = 4 * u - v;
		w.print("w =");

		(vec.prod(u, v)).print("u corss prod v =");
		WriteLine($"u dot (v) = {vec.dot(u, v)}");
		WriteLine($"norm(u) = {vec.norm(u)}");
		WriteLine(u);
	}

}