using Exercicio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Exercicio.Classes
{
    public class Carro
    {
        public Carro()
        {

        }

        public Carro(string modelo, string cor, int ano, Marca marca, string chassi, 
            Proprietario proprietário, int velocidadeMaxima, int velocidadeAtual, 
            int numeroDePortas, bool temTetoSolar, int numeroMarchas, 
            bool temCambioAutomatico, double volumeCombustivel)
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Marca = marca;
            Chassi = chassi;
            Proprietário = proprietário;
            VelocidadeMaxima = velocidadeMaxima;
            VelocidadeAtual = velocidadeAtual;
            NumeroDePortas = numeroDePortas;
            TemTetoSolar = temTetoSolar;
            NumeroMarcha = numeroMarchas;
            TemCambioAutomatico = temCambioAutomatico;
            VolumeCombustivel = volumeCombustivel;
        }

        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public Marca Marca { get; set; }
        public string Chassi { get; set; }
        public Proprietario Proprietário { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public int NumeroDePortas { get; set; }
        public bool TemTetoSolar { get; set; }
        public int NumeroMarcha { get; set; }
        public bool TemCambioAutomatico { get; set; }
        public double VolumeCombustivel { get; set; }

        public void Acelera()
        {
            VelocidadeAtual += 1;
        }

        public void Freiar()
        {
            VelocidadeAtual = 0;
        }

        public void TrocarMarcha(int marcha)
        {
            if(marcha == 0 && VelocidadeAtual > 0) throw new DomainException("Não pode engatar a ré, pois velocidade é superior a 0.");

            throw new DomainException("Marcha passada com sucesso!");
        }

        public void ReduzirMarcha()
        {
            throw new DomainException("Marcha reduzida com sucesso!");
        }
    }
}
