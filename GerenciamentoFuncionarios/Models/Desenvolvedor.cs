using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Models
{
    public class Desenvolvedor(string nome, int idade, float salario, string linguagemPrincipal) : Funcionario(nome,idade,salario)
    {
        public string LinguagemPrincipal { get; set; } = linguagemPrincipal;

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Desenvolvedor: {Nome}, Idade: {Idade}, Salário: {Salario}, Linguagem Principal: {LinguagemPrincipal}");
        }

        public override float CalcularBonificacao()
        {
            float bonificacao = (Salario * 0.20f);
            return bonificacao;
        }

        public override string ToString()
        {
            return $"Desenvolvedor: {Nome}, Idade: {Idade}, Salário: {Salario:C}, Linguagem Principal: {LinguagemPrincipal}, Bonificação: {CalcularBonificacao():C}";
        }
    }
}