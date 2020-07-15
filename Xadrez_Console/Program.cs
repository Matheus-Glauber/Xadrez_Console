using System;
using System.Security.Cryptography.X509Certificates;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.exceptions;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez NovaPartida = new PartidaDeXadrez();

                while (!NovaPartida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(NovaPartida.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();

                    NovaPartida.ExecutaMovimento(Origem, Destino);
                }                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
