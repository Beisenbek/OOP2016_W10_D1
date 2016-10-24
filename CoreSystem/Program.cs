using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Calculators;

namespace CoreSystem
{
	class MainClass
	{
		static List<Calculators.ICalculator> l = new List<Calculators.ICalculator>();

		public static void Main(string[] args)
		{
			while (true)
			{

				var implementationAssemblies = Directory.GetFiles(@"/Users/bsnbk/Desktop/DLLs", "*.dll");


				foreach (var assemblyName in implementationAssemblies)
				{
					var assemblies = Assembly.LoadFile(assemblyName).GetTypes();

					foreach (var assembly in assemblies)
					{
						ICalculator instance = Activator.CreateInstance(assembly) as ICalculator;
						Console.WriteLine(instance.GetSum(2, 3));
					}
				}

				Thread.Sleep(5000);

			}
			/*var c3 = new Calculator3.Calcualator3();
			l.Add((Calculators.ICalculator)c3);

			foreach (var c in l)
			{
				Console.WriteLine(c.GetSum(20, 3));	
			}
			*/
		}
	}
}
