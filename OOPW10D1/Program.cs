using System;
using Calculators;
using Microsoft.Practices.Unity;


namespace OOPW10D1
{
	class Calculator1 : ICalculator
	{
		public int GetSum(int a, int b)
		{
			return a + b;
		}
	}

	class Calculator2 : ICalculator
	{
		public int GetSum(int a, int b)
		{
			return a + b;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Calculator3.Calcualator3 x = new Calculator3.Calcualator3();
			Console.WriteLine(x.GetSum(3, 2));
		}
	}

	/*
	class Factory
	{
		public static ICalculator GetCalculator()
		{
			ICalculator res = new Calculator1();

			return res;
		}	
	}

	class Boostrap
	{
		public static void Setup(UnityContainer container)
		{
			container.RegisterType<ICalculator, Calculator1>("1");
			container.RegisterType<ICalculator, Calculator2>("2");
		}
	}

	class CalculatorTest
	{
		bool TestForType()
		{
			//arrange
			ICalculator a = Factory.GetCalculator();
			//act
			var res = a.GetSum(2, 3);
			//assert
			return res.GetType() == typeof(int);
		}

		bool TestForType2()
		{
			bool ok = false;

			using (UnityContainer container = new UnityContainer())
			{
				Boostrap.Setup(container);
				//arrange
				ICalculator a = container.Resolve<ICalculator>("2");
				//act
				var res = a.GetSum(2, 3);
				//assert
				ok = res.GetType() == typeof(int);
			}

			return ok;

		}
	}*/
}
