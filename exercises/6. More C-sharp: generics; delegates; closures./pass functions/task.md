Exercise "passing functions as parameters to other functions"

Make a function with the signature

```csharp
public static class table{
public static void make_table(Func<double,double> f, double a, double b, double dx){
	for(double x=a;x<=b;x+=dx)WriteLine($"{x} {f(x)}");
	}
}
```

that prints a table, {x, f(x)}x=a, a+dx, a+2dx, ..., b , to the standard output. Put it in a separate file and compile into a library.

Apply this function (in the Main function in a main.cs file) to f(x)=sin(x), f(x)=sin(2x), f(x)=sin(3x). You should use only one delegate, Sin(k*x), and use k as parameter. 
