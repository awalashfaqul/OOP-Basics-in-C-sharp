using System;

namespace GrundernaOOPLabFive
{
	public class Circle
	{
		
		private double radius; // declaring a property to store radius data
		private double pi = 3.14; // declaring another property for 'pi' and
                                  // assigning value in it.


        public Circle(double radius) // Creating a constructor with radius as
									 // a parameter. Keeping it public so that
									 // it can be accessed from other classes
		{
			this.radius = radius; // here by using 'this', actually setting the
									// circle's radius.
		}

		public double GetArea() // Creating a method to calculate the area of
								// circle
		{
			return radius * radius * pi;
		}
	}
}

