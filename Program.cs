using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
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
                { "Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                { "Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar },
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                { "Usando Continue - Estruturas de Controle", UsandoContinue.Executar },

                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar },
                { "Construtores - Classes e Métodos", Construtores.Executar },
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                { "Params - Classes e Métodos", Params.Executar },
            });
        central.SelecionarEExecutar();
    }
}