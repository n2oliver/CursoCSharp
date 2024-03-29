﻿using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Colecoes;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp { 
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
                    { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                    { "Getters e Setters - Classes e Métodos", GetSet.Executar },
                    { "Props - Classes e Métodos", Props.Executar },
                    { "Readonly - Classes e Métodos", Readonly.Executar },
                    { "Enum - Classes e Métodos", ExemploEnum.Executar },
                    { "Struct - Classes e Métodos", ExemploStruct.Executar },
                    { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                    { "Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                    { "Parâmetros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                    { "Parâmetros com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar },

                    // Coleções
                    { "Array - Coleções", Colecoes.Array.Executar },
                    { "List - Coleções", ColecoesList.Executar },
                    { "ArrayList - Coleções", ColecoesArrayList.Executar },
                    { "Set - Coleções", ColecoesSet.Executar },
                    { "Queue - Coleções", ColecoesQueue.Executar },
                    { "Igualdade - Coleções", Igualdade.Executar },
                    { "Stack - Coleções", ColecoesStack.Executar },
                    { "Dictionary - Coleções", ColecoesDictionary.Executar },

                    // OO
                    { "Heranca - OO", Heranca.Executar },
                    { "Construtor This - OO", OO.ConstrutorThis.Executar },
                    { "Encapsulamento - OO", OO.Encapsulamento.Executar },
                    { "Polimorfismo - OO", OO.Polimorfismo.Executar },
                    { "Abstract - OO", OO.Abstract.Executar },
                    { "Interface - OO", OO.Interface.Executar },
                    { "Sealed - OO", OO.Sealed.Executar },

                    // Métodos & Funções
                    { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar },
                    { "Lambdas Delegate - Métodos & Funções", LambdasDelegate.Executar },
                    { "Usando Delegates - Métodos & Funções", UsandoDelegates.Executar },
                    { "Delegates como Funções Anonimas - Métodos & Funções", DelegateFunAnonima.Executar },
                    { "Delegates como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar },
                    { "Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar },

                }); ;
        central.SelecionarEExecutar();
    }
    }
}