using System;
namespace CursoCSharp.MetodosEFuncoes
{
	public class UsandoDelegates
	{
		delegate double Soma(double a, double b);
		delegate void ImprimaSoma(double a, double b);

		static double MinhaSoma(double x, double y)
		{
			return x + y;
        }
        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Executar()
		{
			Soma op1 = MinhaSoma;
			Console.WriteLine(op1(2, 3));

			ImprimaSoma op2 = MeuImprimirSoma;
            op2(5.48, 8);

			Func<double, double, double> op3 = MinhaSoma;
			Console.WriteLine(op3(2.5, 3));

			Action<double, double> op4 = MeuImprimirSoma;
			op4(7.7, 23.4);
        }
	}
}

