using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Lambda
            //get {
            // return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    public class Props
    {
        public static void Executar()
        {

        }
    }
}
