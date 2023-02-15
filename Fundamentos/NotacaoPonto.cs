using System;
namespace CursoCSharp.Fundamentos
{
	public class NotacaoPonto
	{
		public static void Executar()
		{
			var saudacao = "Olá".ToUpper().Insert(3, " World!")
				.Replace("World!", "Mundo!");
			Console.WriteLine(saudacao);
		}
	}
}

