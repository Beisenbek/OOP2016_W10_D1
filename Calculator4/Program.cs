using System;

namespace Calculator4
{
	public class Calculator4 : Calculators.ICalculator
	{
		public int GetSum(int a, int b)
		{
			return a - b;
		}
	}
}
