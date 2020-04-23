using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Base
	{
		public Base(int value)
		{
			a = value;
			Counter++;
		}

		public Base() : this(5)
		{
		}

		~Base()
		{
			Counter--;
		}

		private int a;
		public int b;

		public static int Counter = 0;

		public static void ShowCount()
		{
			Console.WriteLine(Counter);
		}

		public void Set(int value = 63) => a = value;

		public int Get()
		{
			return a;
		}

		public int Get2() => a;

		public void Write(string What)
		{
			Console.WriteLine(What + a);
		}

		public virtual void WriteVirtual()
		{
			Console.WriteLine("Base" + a);
		}
	}

	class Child : Base
	{
		public Child() : base(78)
		{

		}

		public new void Write(string What)
		{
			Console.WriteLine("-------------");
			base.Write(What);
			Console.WriteLine("-------------");
		}

		public override void WriteVirtual()
		{
			Console.WriteLine("Child" + base.Get());
		}
	}
}
