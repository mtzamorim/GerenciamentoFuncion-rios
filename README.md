Implemente um sistema para gerenciar diferentes tipos de funcionários em uma empresa. O sistema deve seguir os requisitos abaixo:


Classe Abstrata Funcionario:
Atributos: string Nome, int Idade, float Salario
Métodos:
public abstract void ExibirInformacoes(); (abstrato)
public abstract float CalcularBonificacao(); (abstrato)
Método construtor para inicializar os atributos.
Classe Gerente (herda de Funcionario):
Atributo: int NumeroFuncionariosGerenciados
Sobrescreva o método ExibirInformacoes para exibir as informações do gerente.
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 10% sobre o salário base multiplicada pelo número de funcionários gerenciados.
Sobrescreva o método ToString() para retornar uma string com as informações do gerente.
Classe Desenvolvedor (herda de Funcionario):
Atributo: string LinguagemPrincipal
Sobrescreva o método ExibirInformacoes para exibir as informações do desenvolvedor.
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 20% sobre o salário base.
Sobrescreva o método ToString() para retornar uma string com as informações do desenvolvedor.
Classe Estagiario (herda de Funcionario):
Atributo: int HorasTrabalhadas
Sobrescreva o método ExibirInformacoes para exibir as informações do estagiário.
Sobrescreva o método CalcularBonificacao para calcular uma bonificação de 5% sobre o salário base multiplicada pelo número de horas trabalhadas.
Sobrescreva o método ToString() para retornar uma string com as informações do estagiário.
Classe Program:
Crie instâncias das classes Gerente, Desenvolvedor e Estagiario.
Preencha os dados usando o construtor e exiba as informações de cada funcionário.
Utilize o método CalcularBonificacao para demonstrar polimorfismo (cada tipo de funcionário tem uma forma diferente de calcular a bonificação).
Exiba as bonificações calculadas e o retorno do método ToString para cada funcionário.
