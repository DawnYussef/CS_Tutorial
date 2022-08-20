using System;

namespace Constr
{
	public static class MathConstr_static
    {
		private static int resultSum = 0;
		public static int Sum(int x, int y) 
		{
			int result = x + y;
			return result;
		}

		public static void Insert(int result)
        {
			resultSum = result;
			Console.WriteLine("Summation using 'private static' int: " + result);
        }

		public static string Static = "\nUsing the 'static void' method - following;" +
				" lesson(s) regarding constructors";
		
	}
	class Constr_public
    {
		public string str;
		
		public Constr_public()
        {
			
			str = "\nConstructor using 'public object'.";
        }
    }
	
	class Constr_wParameter
	{
		public string mod; //String to be modified ...
		public Constr_wParameter(string outputData)
		{
			mod = outputData;
		}
	}
}
