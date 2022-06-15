**Exercise "complex"**

Calculate, using our cmath class, √-1, √i, ei, eiπ, ii, ln(i), sin(iπ) and compare with manually calculated results.

Extra: add to our cmath-class the hyperbolic functions sinh, cosh of complex argument—and calculate sinh(i), cosh(i). Check that the results are correct.

Hints:

    System.Math.E ≈ e, System.Math.PI ≈ π, cmath.I ≈ i.
    Install wget,

    sudo apt install wget

- Then

    cd /path/to/my/complex/class/files

- and get the complex.cs and cmath.cs files,

    wget http://80.251.205.75/~fedorov/prog/matlib/complex/complex.cs
    wget http://80.251.205.75/~fedorov/prog/matlib/complex/cmath.cs

- Add the following lines to your Makefile to build the cmath.dll library,

    CMATHDIR = /path/to/my/complex/class/files
    cmath.dll : $(CMATHDIR)/cmath.cs $(CMATHDIR)/complex.cs
    	mcs -target:library -out:./cmath.dll $^ # note "./" in front of cmath.dll

- Read the source code complex.cs and cmath.cs to find out how the complex numbers and complex function are defined.
  
  Create a main.cs file with the "Main" method that solves the exercise.
  Link with your "cmath.dll" library when compiling your main.cs,

    main.exe : main.cs cmath.dll
    	mcs -reference:cmath.dll main.cs


