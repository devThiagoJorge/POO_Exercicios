using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Exercicio.Classes
{
    public class Marca
    {
        public Marca(string nome, int numeroDeModelos, DateTime anoDeLancamento, Guid codigoIndentificador)
        {
            Nome = nome;
            NumeroDeModelos = numeroDeModelos;
            AnoDeLancamento = anoDeLancamento;
            CodigoIndentificador = codigoIndentificador;
        }

        public string Nome { get; set; }
        public int NumeroDeModelos { get; set; }
        public DateTime AnoDeLancamento { get; set; }
        public Guid CodigoIndentificador { get; set; }
    }
}
