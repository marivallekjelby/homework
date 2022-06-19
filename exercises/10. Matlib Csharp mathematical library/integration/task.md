
1. (mandatory)

* Using the integrate.quad routine from integrate.cs calculate numerically the intergral (exact value is -4),

`∫01 dx (ln(x)/√x)`

You can either copy/paste the content of the link into the file "integrate.cs", or wget the file,

`wget http://80.251.205.75/~fedorov/prog/matlib/integrate/integrate.cs`

Your main.cs might look like

```csharp
Func<double,double> f = delegate(double x){return Log(x)/Sqrt(x);};
double result = integrate.quad(f,0,1);
```

or, equivalently, using a _lambda-expression_:

```csharp        
Func<double,double> f = x => Log(x)/Sqrt(x);
double result = integrate.quad(f,0,1);
```

Your makefile might look like

	
```makefile        
out.txt:main.exe
	mono $< > $@
main.exe: main.cs matlib.dll
        mcs -target:exe -reference:matlib.dll -out:$@ $<
matlib.dll: integrate.cs
        mcs -target:library -out:$@ $<
```

* Using the integrate.quad routine from integrate.cs implement the [error-function] using its integral representation. Make a plot.

Something like
```csharp
	public static double erf(double z){
        	Func<double,double> f = x => Exp(-x*x);
        	return integrate.quad(f,0,z)*2/Sqrt(PI);
        }
```

2. (optional) Using the integrate.quad routine from integrate.cs implement the Bessel function (of the first kind) using its [integral representation]. Make plots, compare with your numpy/scipy routines.

3. (optional) Improve the effectiveness of your error-function implementation by switching the integration limits from {0,x} to {x,∞} for, say, x>1. Check the number of integrand calls for the naive and the (probably) more effective implementation. Hint: positive infinity in Csharp is double.PositiveInfinity,

```csharp
double infin = double.PositiveInfinity;
```
