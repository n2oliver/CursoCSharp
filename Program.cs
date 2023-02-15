namespace CursoCSharp.Fundamentos;
class Program
{
    static void Main(string[] args)
    {
        CentralDeExercicios central = new CentralDeExercicios(
            new Dictionary<string, Action>() {
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Variáveis e Contantes - Fundamentos", VariaveisEConstantes.Executar},
                { "Inferência - Fundamentos", Inferencia.Executar},
                { "Interpolação - Fundamentos", Interpolacao.Executar},
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar},
            });
        central.SelecionarEExecutar();
    }
}