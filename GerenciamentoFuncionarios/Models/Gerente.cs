using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Models
{
    public class Gerente(string nome, int idade, float salario, int numeroFuncionariosGerenciados) : Funcionario(nome,idade,salario)
    {
        public int NumeroFuncionariosGerenciados { get; set; } = numeroFuncionariosGerenciados;

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Gerente: {Nome}, Idade: {Idade}, Salário: {Salario}, Numero de Funcionários Gerenciados: {NumeroFuncionariosGerenciados}");
        }

        public override float CalcularBonificacao()
        {
            float bonificacao = (Salario * 0.10f) * NumeroFuncionariosGerenciados;
            return bonificacao;
        }

        public override string ToString()
        {
            return $"Gerente: {Nome}, Idade: {Idade}, Salário: {Salario:C}, Funcionários Gerenciados: {NumeroFuncionariosGerenciados}, Bonificação: {CalcularBonificacao():C}";
        }
    }
}