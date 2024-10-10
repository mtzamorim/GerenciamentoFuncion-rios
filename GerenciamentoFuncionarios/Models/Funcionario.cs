using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Models
{
    public abstract class Funcionario(string nome, int idade, float salario)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;
        public float Salario { get; set; } = salario;

        public abstract void ExibirInformacoes();

        public abstract float CalcularBonificacao();
    }
}