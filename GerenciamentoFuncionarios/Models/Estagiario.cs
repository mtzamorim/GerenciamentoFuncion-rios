using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Models
{
    public class Estagiario(string nome, int idade, float salario, int horasTrabalhadas) : Funcionario(nome, idade, salario)
    {
        public int HorasTrabalhadas { get; set; } = horasTrabalhadas;

         public override void ExibirInformacoes()
        {
            Console.WriteLine($"Estagiario: {Nome}, Idade: {Idade}, Salário: {Salario}");
        }

        public override float CalcularBonificacao()
        {
            float bonificacao = (Salario * 0.05f) * HorasTrabalhadas;
            return  bonificacao;
        }

        public override string ToString()
        {
            return $"Estagiário: {Nome}, Idade: {Idade}, Salário: {Salario:C}, Horas Trabalhadas: {HorasTrabalhadas}, Bonificação: {CalcularBonificacao():C}";
        }
    }
}