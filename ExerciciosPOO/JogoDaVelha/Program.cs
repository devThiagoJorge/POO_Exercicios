using System;
using JogoDaVelha.Classes;
using JogoDaVelha.Enum;

namespace JogoDaVelha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jogo = new Jogo();
            Console.WriteLine("Bem vindo ao jogo, o jogo começa com o player 1.");
            int player1 = (int)PossibilidadesEnum.Player1;
            int player2 = (int)PossibilidadesEnum.Player2;
            int linha = 0;
            int coluna = 0;
            bool vezPlayer1 = true;
            jogo.MostrarGrade();

            while (true)
            {
                if (vezPlayer1)
                {
                    Console.WriteLine("\nVez do player 1");
                    linha = DefinirLinha();
                    coluna = DefinirColuna();
                    jogo.FazerJogada(linha, coluna, player1);
                    vezPlayer1 = false;
                }
                else
                {
                    Console.WriteLine("\nVez do player 2");
                    linha = DefinirLinha();
                    coluna = DefinirColuna();
                    jogo.FazerJogada(linha, coluna, player2);

                    vezPlayer1 = true;
                }
            }
  
        }

        public static int DefinirLinha()
        {
            Console.WriteLine("Informe a linha: ");
            int linha = int.Parse(Console.ReadLine());
            return linha;
        }

        public static int DefinirColuna()
        {
            Console.WriteLine("Informe a coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            return coluna;
        }
    }
}
