using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Opertaion
    {
		double a, b;

		public void SetA(double in_a)
		{
			a = in_a;
		}

		public double GetA()
		{
			return a;
		}

		public void SetB(double in_b)
		{
			b = in_b;
		}

		public double GetB()
		{
			return b;
		}

		public double Addition()
		{
			return Math.Round(a + b, 4);
		}

		public double Subscraction()
		{
			return Math.Round(a - b, 4);
		}

		public double Multiplication()
		{
			return Math.Round(a * b, 4);
		}

		public double Devision()
		{
			return Math.Round(a / b, 4);
		}


	}
}
