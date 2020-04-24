using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Test
{
	class Username
	{


		public static void Main(string[] args)
		{
			var sw = new Stopwatch();
			sw.Start();

			for (int i = 1; i <= 1000; i++)
				Console.WriteLine(i);

			sw.Stop();

			Console.WriteLine(sw.ElapsedMilliseconds);

		}
	}
}
