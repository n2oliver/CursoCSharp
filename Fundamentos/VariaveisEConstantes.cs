namespace CursoCSharp.Fundamentos
{
	public class VariaveisEConstantes
	{
		public static void Executar()
		{
			double raio = 4.5;
			const double PI = 3.14;

			raio = 5.5;
			// PI = 3.1415;

			double area = PI * raio * raio;
			Console.WriteLine(area);
			Console.WriteLine("A área é " + area);

			bool estaChovendo = false;
			Console.WriteLine("Está chovendo " + estaChovendo);

			byte idade = 45;
			Console.WriteLine("Idade " + idade);

			sbyte saldoDeGols = sbyte.MinValue;
			Console.WriteLine("Saldo de Gols " + saldoDeGols);

			short salario = short.MaxValue;
			Console.WriteLine("Salario " + salario);

			int menorValorInt = int.MinValue; // Mais usado dos inteiros
			Console.WriteLine("Menor int " + menorValorInt);

			uint populacaoBrasileira = 207_600_000;
			Console.WriteLine("População Brasileira " + populacaoBrasileira);

			long menorValorLong = long.MinValue;
			Console.WriteLine("Menor long " + menorValorLong);

			ulong populacaoMundial = 7_600_000_000;
			Console.WriteLine("População Mundial " + populacaoMundial);

			float precoComputador = 1299.99f;
			Console.WriteLine("Preço Computador " + precoComputador);

			double valorDeMercadoDaApple = 1_000_000_000_000;
			Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

			decimal distanciaEntreAsEstrelas = decimal.MaxValue;
			Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

			char letra = 'b';
			Console.WriteLine("Letra " + letra);

			string texto = "Seja bem vindo ao Curso de C#!";
			Console.WriteLine(texto);
		}
	}
}

