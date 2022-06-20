using System;
using static System.Console;
using static System.Math;
using System.Collections;
using System.Collections.Generic;

class main
{
	static void Main()
	{
		double b = 0.25;
		double c = 5.0;
		vector y_start = new vector(PI - 0.1, 0.0);

		Func<double, vector, vector> F = delegate (double t, vector y) {
			double theta = y[0];
			double omega = y[1];
			return new vector(omega, -b * omega - c * Sin(theta));
		};

		double start = 0, stop = 10;

		var xlist = new List<double>();
		var ylist = new List<vector>();
		vector y_stop = ode.ivp(F, start, y_start, stop, xlist, ylist);

		for (int i = 0; i < xlist.Count; i++)
			WriteLine($"{xlist[i]}	{ylist[i][0]}	{ylist[i][1]}");

	}

}