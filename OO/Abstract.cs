using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        
        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung(),
            };
            Console.WriteLine(celulares[0].Assistente());
            Console.WriteLine(celulares[1].Assistente());
        }
    }
}
