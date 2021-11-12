using JogoDaVelha.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Classes
{
    public class Jogo
    {
        public Jogo()
        {
            Grade = new int[3, 3];
        }

        public  int[,] Grade { get; private set; }

        private void InformacoesIniciais()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("0 = VAZIO");
            Console.WriteLine("1 = PLAYER 1");
            Console.WriteLine("2 = PLAYER 2");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
        }

        public void MostrarGrade()
        {
            InformacoesIniciais();

            Console.WriteLine("      0          1          2");
            for (int i = 0; i < 3; i++)
            { 
                Console.WriteLine("_________________________________");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|     {Grade[i, j]}    ");
                }
               
                Console.Write("|" +  " " +  i);
                
                Console.WriteLine("");
            }
            Console.Write("_________________________________");
        }

        public void FazerJogada(int linha, int coluna, int player)
        {
            if(Grade[linha,coluna] != (int)PossibilidadesEnum.Vazio)
            {
                Console.WriteLine($"Jogada não permitida, pois esse campo já foi preenchido pelo player: {Grade[linha, coluna]}");
                return;
            }
            else
            {
                Grade[linha, coluna] = player;
            }

            MostrarGrade();
        }

        
    }
}
