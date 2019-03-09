using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValue
{
	class Program
	{
		static void Main(string[] args)
		{
			int code = 1;
			Code obj = new Code(1);
			Increment(ref code);
			Increment(obj);
			Console.WriteLine("code = " + code);
			Console.WriteLine("codeobj = " + obj.code);

			int[] nums = { 4, 8, 8, 22, 5 };
			Console.WriteLine("T1 = " + Sum(nums));
			Console.WriteLine("T2 = " + Sum(1, 2, 3));
			Console.WriteLine("T3 = " + Sum());

			// What is displayed for num and code? 
			Console.ReadKey();
		}

		public static void Increment(ref int code) { code++; }
		public static void Increment(Code obj) { obj.code++; }

		static int Sum(params int[] vals)
		{
			int total = 0;
			foreach (int i in vals)
			{
				total += i;
			}
			return total;
		}



	}

	class Code
	{
		public int code { get; set; }
		public Code(int code)
		{
			this.code = code;
		}
	}
}
