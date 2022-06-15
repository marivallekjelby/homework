Exercise "LaTeX"
First, install LaTeX on your system:

    * Debian based systems: install Tex Live distribution with the command

    sudo apt-get install texlive texlive-latex-extra texlive-font-utils

    * MacOS with HomeBrew: install MacTeX distribution. It seems that you first need to install "homebrew cask" and then

    brew cask install mactex

    or

    brew cask install basictex # allegedly a small but functional version of MacTeX

Now, the exercises:

    1. (Mandatory) Consider the following "quick-and-dirty" implementation of the exponential function (which only uses multiplications and divisions),

	```csharp
    	static double ex(double x){
    		if(x<0) return 1/ex(-x);
    		if(x>1.0/8)return Pow(ex(x/2),2); // explain this
    		return 1+x*(1+x/2*(1+x/3*(1+x/4*(1+x/5*(1+x/6*(1+x/7*(1+x/8*(1+x/9*(1+x/10)))))))));
    	}
	```

    	Make a one-/two- page report, in LaTeX, about this implementation along the following lines: i) introduce the exponential function; ii) explain why this implementation might actually work; iii) test whether it works in practice. There should be plots in your report.

    2. (Optional)
        
	1. Is there any numerical advantage in using this convoluted expression for the Taylor series,

        	1+x*(1+x/2*(1+x/3*(1+x/4*(1+x/5*(1+x/6*(1+x/7*(1+x/8*(1+x/9*(1+x/10)))))))));

        	instead of the ordinary

        	1+x+x2/2!+x3/3!+x4/4!+...

        	?

        2. Is there any numerical advantage in inverting the sign of the argument for negative arguments? 

    3. (Optional) Make a complex version of this implementation,
	```csharp
    	static complex cex(complex z){
    		...
    	}
	```
    	and check whether it works or not. 
