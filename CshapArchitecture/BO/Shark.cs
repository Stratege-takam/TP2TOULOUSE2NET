using CshapArchitecture.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshapArchitecture.BO
{
	public class Shark : Animal, ISwimmable
	{
		

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		void ISwimmable.Swim()
		{
			throw new NotImplementedException();
		}
	}
}
