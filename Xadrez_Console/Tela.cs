using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int linhas = 0; linhas < tabuleiro.Linhas; linhas++)
            {
                for (int colunas = 0; colunas < tabuleiro.Colunas; colunas++)
                {
                    if (tabuleiro.Peca(linhas, colunas) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tabuleiro.Peca(linhas, colunas) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
