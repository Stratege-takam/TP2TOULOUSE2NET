using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPart
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 5, j;
	
			j = i;
			i = 3;
			Console.WriteLine("i ={0} and j = {1}",i,j);
			Account account = new Account();
			Account account1;
			account1 = account;
			account.name = "test";
			account1.number = 5;
			Console.WriteLine("account1 name = {0} account name = {1}", account1.name, account.name);
			Console.WriteLine("account1 number ={0} account number = {1}",account1.number, account.number);
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.WriteLine("Hello World!");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
