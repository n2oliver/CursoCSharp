﻿using System;
namespace CursoCSharp.ClassesEMetodos
{
	public class DesafioAtributo
	{
		int a = 10;

		public static void Executar()
        {
            // Acessar a variável 'a' dentro da ação Executar!
            DesafioAtributo desafio = new DesafioAtributo();
			Console.WriteLine(desafio.a);
		}
	}
}

