# Executable Path

```
Eksamen/bin/Debug/net6.0/Eksamen.exe
```
*Output is stored in the base folder for preview*



Author: Mari Valle Kjelby

Student number: 202110385

Exam question: 16, Cubic (sub-)spline for data with derivatives

In this project I have built a cubic spline from a data set that includes a tabulated function  and the derivativeof the tabulated function at the data point x_i.


The cubic subspline was given by the equation
S_i(x) = y_i + b_i(x-x_i) + c_i(x-x_i)^2 + d_i(x-x_i)^3,
and the three coefficients were determined by the three following conditions:
S_i(x_i+1) = y_i+1
S'_i(x_i) = y'_i
S'_i(x_i+1) = y'_i+1

By following the cubic spline steps from lecture 11 the  coefficients were found to be:
b_i = p_i
c_i= -2 * b_i - b_(i+1) + 3 * y_der_i / h(i)
d_i = b_i + b_(i+1) - 2 * y_der(i) / h(i)^2

where 

h(i) = x_(i+1) - x_i  

To build the spline I first moved the user variables to global variables.  Then I replaced the firstand last values of the arrays....


rate myself!!!!!
