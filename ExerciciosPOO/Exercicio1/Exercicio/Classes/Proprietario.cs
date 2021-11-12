using Exercicio1.Exercicio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Classes
{
    public class Proprietario
    {
        public Proprietario(string nome, string cpf, string rg, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
