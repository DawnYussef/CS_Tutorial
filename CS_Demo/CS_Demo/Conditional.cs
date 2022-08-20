using System;

namespace Cond
{
    class If_Else
    {
		public If_Else(int n)
		{
			if (n > 0)
			{
				Console.WriteLine("...example of 'if' statement");
				// :: FALSE - statement will not print

			}
			else if (n < 0)
			{
				Console.WriteLine("...example of 'else if' statement");
				// :: FALSE - statement will not print

			}
			else
			{
				Console.WriteLine("Both 'IF' & 'ELSE IF' are FALSE; print - ELSE ");
				Console.WriteLine("Shorthand - If...Else(Ternary Operator):");
			}

			string result = (n <= 0) ? "*CONDITIONAL - 'n' is less than or equal to 0\n" : "FALSE";
			Console.WriteLine(result);
		}
    }

    class SwitchCase
	{
		public int iter = 0;
		public SwitchCase()
        {
            switch (iter)
            {
				case 0:
					Console.WriteLine("Iterator: " + iter + "\n");
					break;
				case 1:
					Console.WriteLine("Iterator: " + iter + "\n");
					break;
				case 2:
					Console.WriteLine("Iterator: " + iter + "\n");
					break;
				case 3:
					Console.WriteLine("Iterator: " + iter + "\n");
					break;
				default:
					Console.WriteLine("Default: " + iter + "\n");
					break;
			}		
		}
    }

	class Conditional_Loop
	{
		public int iter = 0;
		public void WhileLoop(int iter)
		{
			while (iter < 3)
			{
				Console.WriteLine("Example of While Loop:\n Permutation - " + iter);
				iter++;
			}
		}
	/*}

	class*/ 
		public void Do_While(int iter)
        {
			
			do
			{
				Console.WriteLine("Example of Do/While Loop:\n Permutation - " + iter);
				iter++;
			}
			while (iter < 3);
        }
    }

	class Recursion
	{
		private int _enumRecursion;
		public int enumRecursion
		{
			get{return _enumRecursion; }
			set{_enumRecursion = value; }
        }

		
		public void Statement(string txt)
        {
			Console.WriteLine(txt);
        }
		public void Statement(ref string txt) 
		{
			txt = "...Unavailable";
			Console.WriteLine(txt);
		}

		public int Sum(int x, int y, out int enumRecursion) 
		{
			int result = x + y;
			enumRecursion = 0;

			Console.Out.Write(" -- enumRecursion value = " + enumRecursion);
			return result;

		}

		public void RecurSum(int a, int b) 
        {
			int sum = 0;
			while(sum < 100)
            {
				int instance = enumRecursion;
				a = (b * instance);
				sum = Sum(a, b, out instance);
				Console.Write(" -- i(" + enumRecursion + "): " + sum);
				string txt = "\ny = x(interval);\nf(x) = x + y";
				Statement(txt);
				//void nonStatement(ref string txt){ };
				Statement(ref txt);
				enumRecursion++;
				
            }
        }
    }
}
