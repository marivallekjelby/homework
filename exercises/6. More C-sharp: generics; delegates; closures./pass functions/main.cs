﻿using static System.Math;
using static System.Console;
using System;
using static table;
class main
{

	public static void Main()
	{
		for (int k = 1; k <= 3; k++)
		{
			WriteLine($"Printing table");
			Func<double, double> sinkx = delegate (double x) {
				return Sin(k * x);
			};
			table.make_table(sinkx, 0, 2 * PI, 0.1);
			WriteLine();
		}
	}

}
