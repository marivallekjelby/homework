**Exercise "epsilon"**

Maximum/minimum representable integers; Machine epsilon; How to compare two doubles; 

1. Maximum/minimum representable integers.
	- The maximum representable integer is the largest integer i for which i+1>i holds true. 

		Using the `while` loop determine your maximum integer and compare it with int.MaxValue
		Hint: something like

		```csharp
			int i = 1; while(i+1>i) {i++;}
			Write("My max int = {0}\n", i);
		```

		It can take some seconds to calculate.

	- The minimum representable integer is the most negative integer i for which i-1<i holds true.

		Using the while loop determine your minimum integer and compare with int.MinValue. 

2. The machine epsilon is the difference between 1.0 and the next representable floating point number. Using the 
   while loop calculate the machine epsilon for the types float and double. Something like 

	```csharp
	double x=1; while(1+x!=1){x/=2;} x*=2;
	float y=1F; while((float)(1F+y) != 1F){y/=2F;} y*=2F;
	```

	There seem to be no predefined values for this numbers in csharp (I couldn't find it in any case). However,
	in a IEEE 64-bit floating-point number (double), where 1bit is reserved for the sign and 11bits for 
	exponent, there are 52bits remaining for the fraction, therefore the double machine epsilon must be about 
	System.Math.Pow(2,-52). For single precision (float) the machine epsilon should be about 
	System.Math.Pow(2,-23). Check this. 

3.  Suppose tiny=epsilon/2. Calculate the two sums, 

	```csharp
	sumA=1+tiny+tiny+...+tiny;
	sumB=tiny+tiny+...+tiny+1;
	```


	which should seemingly be the same and print out the values sumA-1 and sumB-1. Explain the difference. 
	Someting like 

	```csharp
	int n=(int)1e6;
	double epsilon=Pow(2,-52);
	double tiny=epsilon/2;
	double sumA=0,sumB=0;

	sumA+=1; for(int i=0;i<n;i++){sumA+=tiny;}
	WriteLine($"sumA-1 = {sumA-1:e} should be {n*tiny:e}");

	for(int i=0;i<n;i++){sumB+=tiny;} sumB+=1;
	WriteLine($"sumB-1 = {sumB-1:e} should be {n*tiny:e}");
	```

4. Implement a function with the signature 

	```csharp
	bool approx(double a, double b, double tau=1e-9, double epsilon=1e-9)
	```

	that returns true if the numbers 'a' and 'b' are equal with absolute precision τ, 

	`|a-b|<τ`

	or are equal with relative precision 'epsilon',

	`|a-b|/(|a|+|b|)<ε`

	and returns false otherwise. Test it. 
