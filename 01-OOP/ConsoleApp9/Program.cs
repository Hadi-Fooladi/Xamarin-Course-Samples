using System;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			//Base B = new Base();
			//var C = new Base(7);
			//B.Write("Hello!");
			//B.Set(15);
			//B.Write("Hello!");
			//B.Set();
			//B.Write("Hello!");

			//C.Write("C");

			Base.ShowCount();

			var obj = new Child();
			//obj.b = 1;
			//Console.WriteLine(obj.Get());
			//obj.Write("Child");

			foo(obj);

			Base.ShowCount();

			var B = new Base();

			foo(B);

			Base.ShowCount();

			Console.ReadKey();
		}

		static void foo(Base B)
		{
			B.Write("foo");
			B.WriteVirtual();
		}
	}
}
