using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
namespace CursoCSharp;
class Program
{
    static void Main(string[] args)
    {
        CentralDeExercicios central = new CentralDeExercicios(
            new Dictionary<string, Action>() {
                // Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Variáveis e Contantes - Fundamentos", VariaveisEConstantes.Executar},
                { "Inferência - Fundamentos", Inferencia.Executar},
                { "Interpolação - Fundamentos", Interpolacao.Executar},
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                { "Lendo Dados - Fundamento s", LendoDados.Executar},
                { "Formatando Número - Fundamentos", FormatandoNumero.Executar},
                { "Conversões - Fundamentos", Conversoes.Executar},
                { "Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                { "Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                { "Operador Ternario - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
            });
        central.SelecionarEExecutar();
    }
}