using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		complex munisone = new complex(-1,0);
		WriteLine($"sqrt(-1) = {cmath.sqrt(munisone)}");
		WriteLine($"sqrt(i) = {cmath.sqrt(cmath.I)}");
		WriteLine($"e^i = {cmath.exp(cmath.I)}");
		WriteLine($"e^i*pi = {cmath.exp(cmath.I*PI)}");
		WriteLine($"i^i = {cmath.pow(cmath.I, cmath.I)}");
		WriteLine($"ln(i) = {cmath.log(cmath.I)}");
		WriteLine($"sin(i*pi) = {cmath.sin(cmath.I*PI)}");		


	}



}

