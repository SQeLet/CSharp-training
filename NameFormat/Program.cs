using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Username
	{
		static string name;

		public static void user (string s)
		{
			name = s;
		}

		public static string Format1()
		{
			name = name.Trim();
			string[] name_f1 = name.Split();
			return name_f1[0] + " " + name_f1[1][0] + "." + name_f1[2][0] + ".";
		}

		public static string Format2()
		{
			name = name.Trim();
			string[] name_f2 = name.Split();
			return name_f2[1] + " " + name_f2[2] + " " + name_f2[0];
		}




		public static void Main(string[] args)
		{
			user("Ivanov Dmitry Petrovich");

			Console.WriteLine(Format1());
			Console.WriteLine(Format2());

		}
	}
}
