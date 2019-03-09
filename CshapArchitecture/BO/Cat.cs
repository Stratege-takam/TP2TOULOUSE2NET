using CshapArchitecture.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshapArchitecture.BO
{
	public class Cat : Animal,IWalkable
	{
		public void Breath()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		public void Walk()
		{
			throw new NotImplementedException();
		}
	}
}
