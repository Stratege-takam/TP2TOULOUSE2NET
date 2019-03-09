using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				AskValues();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Main(args);
			}
			Console.ReadLine();
		}

		static void AskValues()
		{
			try
			{
				Console.Write("Enter the numpber 1 : ");
				float n1 = float.Parse( Console.ReadLine());


				Console.Write("Enter the numpber 2 : ");
				float n2 = float.Parse(Console.ReadLine());


				Console.Write("Enter the operation : \n 1) + \n 2) - \n 3) * \n 4) % \n 5) /  ");
				int operation = int.Parse( Console.ReadLine());
				float result  = Compute(n1, n2, operation);
				Console.WriteLine("{0} {1} {2} = {3}", n1, Compute(operation), n2, result);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		static float Compute(float n1, float n2, int operation)
		{
			float result =0;
			
			switch (operation)
			{
				case 1:
					result = n1 + n2;
					break;
				case 2:
					result = n1 - n2;
					break;
				case 3:
					result = n1 * n2;
					break;
				case 4:
					result = n1 % n2;
					break;
				case 5:
					if (n2==0)
					{
						throw new Exception(" Division by zero is not possible");
					}
					result = n1 / n2;
					break;
			}
			return result;
		}


		static string Compute(int operation)
		{
			string result = "";
				switch (operation)
				{
					case 1:
						result = "+";
						break;
					case 2:
						result ="-";
						break;
					case 3:
						result = "*";
						break;
					case 4:
						result = "%";
						break;
					case 5:
						result = "/";
						break;
				}
			
			return result;
		}
	}
}
