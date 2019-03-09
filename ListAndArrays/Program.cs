using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>() {
				"James", "John", "Katie", "Mark", "Patrick",
				"Bob", "Rupert", "Brian", "Kevin", "Walter"
			  };

			foreach (string n in names.SortByLastLetter())
			{
				Console.WriteLine(n);
			}
			Console.ReadLine();

			

		}
	}

	static class ExtensionList
	{
		public static List<string> SortByLastLetter(this List<string> list)
		{
			return list == null || list.Count() == 0 ? list : list.OrderBy(f => f.LastOrDefault()).ToList();
		}
	}

	public class Stack<T>
	{
		int position;
		T[] data = new T[100];
		
		public void Push(T obj) {  data[position++] = obj; }

		public T Pop() { return data[--position]; }
	}

}
