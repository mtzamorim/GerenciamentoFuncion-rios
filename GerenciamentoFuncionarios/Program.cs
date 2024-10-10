using GerenciamentoFuncionarios.Models;

Gerente gerente = new("Matheus Amorim", 24, 3000f, 2);

Desenvolvedor desenvolvedor = new("Arthur Garcia", 36, 2000f, "C#");

Estagiario estagiario = new("Westn", 39, 1000f, 40);
// Com metodo Exibir informações
gerente.ExibirInformacoes();
desenvolvedor.ExibirInformacoes();
estagiario.ExibirInformacoes();
//Bonificação
Console.WriteLine("\nBonificações Calculadas:");
Console.WriteLine($"{gerente.Nome}: {gerente.CalcularBonificacao():C}");
Console.WriteLine($"{desenvolvedor.Nome}: {desenvolvedor.CalcularBonificacao():C}");
Console.WriteLine($"{estagiario.Nome}: {estagiario.CalcularBonificacao():C}");

//Com ToString
Console.WriteLine("\nInformações detalhadas:");
Console.WriteLine(gerente.ToString());
Console.WriteLine(desenvolvedor.ToString());
Console.WriteLine(estagiario.ToString());
