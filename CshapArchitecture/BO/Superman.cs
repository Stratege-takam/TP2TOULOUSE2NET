using CshapArchitecture.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshapArchitecture.BO
{
	public class Superman : MineralVegetal,IFlyable
	{
		public void Fly()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}
	}
}
