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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Verde, tab), new Posicao(6, 7));
                tab.ColocarPeca(new Torre(Cor.Verde, tab), new Posicao(7, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
