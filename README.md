Implemente um sistema para gerenciar diferentes tipos de funcionários em uma empresa. O sistema deve seguir os requisitos abaixo:


Classe Abstrata Funcionario:<br>
Atributos: string Nome, int Idade, float Salario<br>
Métodos:<br>
public abstract void ExibirInformacoes(); (abstrato)<br>
public abstract float CalcularBonificacao(); (abstrato)<br>
Método construtor para inicializar os atributos.<br>
Classe Gerente (herda de Funcionario):<br>
Atributo: int NumeroFuncionariosGerenciados<br>
Sobrescreva o método ExibirInformacoes para exibir as informações do gerente.<br>
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 10% sobre o salário base multiplicada pelo número de funcionários gerenciados.<br>
Sobrescreva o método ToString() para retornar uma string com as informações do gerente.<br>
Classe Desenvolvedor (herda de Funcionario):<br>
Atributo: string LinguagemPrincipal<br>
Sobrescreva o método ExibirInformacoes para exibir as informações do desenvolvedor.<br>
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 20% sobre o salário base.<br>
Sobrescreva o método ToString() para retornar uma string com as informações do desenvolvedor.<br>
Classe Estagiario (herda de Funcionario):<br>
Atributo: int HorasTrabalhadas<br>
Sobrescreva o método ExibirInformacoes para exibir as informações do estagiário.<br>
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 5% sobre o salário base multiplicada pelo número de horas trabalhadas.<br>
Sobrescreva o método ToString() para retornar uma string com as informações do estagiário.<br>
Classe Program:<br>
Crie instâncias das classes Gerente, Desenvolvedor e Estagiario.<br>
Preencha os dados usando o construtor e exiba as informações de cada funcionário.<br>
Utilize o método CalcularBonificacao para demonstrar polimorfismo (cada tipo de funcionário tem uma forma diferente de calcular a bonificação).<br>
Exiba as bonificações calculadas e o retorno do método ToString para cada funcionário.<br>
