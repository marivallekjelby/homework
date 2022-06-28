Author: Mari Valle Kjelby

Student number: 202110385

Exam question: 16, Cubic (sub-)spline for data with derivatives



In this project I have built a cubic spline from a data set that includes a tabulated function and the derivative of the tabulated function at the data point x_i.

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

In general a cubic spline is a piecewise cubic function that is used to interpolate a set of data points, and it is a method that guarantees smoothness at the data points. The cubic spline will minimize the total curvature of the interpolating function. When we use a spline to interpolate we avoid the problem of Runge’s phenomenon, which is oscillation at the edges of the interval. The cubic spline function is continous with its first and second derivatives, which is what goves us our conditions for the coefficients. 

To build the cubic spline (cspline.cs) I followed the process of cubic splines in the document "interpolation" from week 11. It was especially used to find the coefficients in the function. When this was done the arrays was sorted before using binary search to find the position of a target value within the array to perform the spline.

In the cspline.cs file I have made the cspline class which is called upon in the main.cs file and used to perform the cubic spline on the dataset.




