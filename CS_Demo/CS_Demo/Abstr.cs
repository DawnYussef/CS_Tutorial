using System;
namespace Abstr
{
	abstract class Abstract_Class
	{
		public abstract void abstrMethod(string str, int x);
		public void non_abstrMethod()
		{
			string str = "String w/o abstract class methods.";
			Console.WriteLine(str);
		}
	}

	class Non_Abstract : Abstract_Class
	{

		public override void abstrMethod(string str, int x)
		{
			Console.WriteLine(str + "Return " + x);
		}
	}
}
