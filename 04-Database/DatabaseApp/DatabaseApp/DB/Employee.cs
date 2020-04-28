using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseApp.DB
{
	class Employee : Person
	{
		public int Wage { get; set; }

		public override string ToString() => $"{base.ToString()} <Wage: {Wage}>";
	}
}
