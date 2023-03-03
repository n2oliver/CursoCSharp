﻿using System;
namespace CursoCSharp.ClassesEMetodos
{
	public class MetodosComRetorno
	{
		class CalculadoraComum
		{
			public int Somar(int a, int b)
			{
				return a + b;
            }
            public int Subtrair(int a, int b)
            {
                return a - b;
            }
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
		class CalculadoraCadeia
		{
			int memoria;

			public CalculadoraCadeia Somar(int a)
			{
				memoria += a;
				return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }
        }
		public static void Executar()
		{
			var calculadoraComum = new CalculadoraComum();
			var resultado = calculadoraComum.Somar(5, 5);
			Console.WriteLine(resultado);

			Console.WriteLine(calculadoraComum.Subtrair(2, 7));
			Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
		}
	}
}

