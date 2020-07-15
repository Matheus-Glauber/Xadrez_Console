using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console.xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();

            Peca PecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tabuleiro.ColocarPeca(new Torre(Cor.Branca, tabuleiro), new PosicaoXadrez('c', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new PosicaoXadrez('c', 2).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(Cor.Verde, tabuleiro), new PosicaoXadrez('g', 6).ToPosicao());
            tabuleiro.ColocarPeca(new Torre(Cor.Verde, tabuleiro), new PosicaoXadrez('b', 7).ToPosicao());
        }
    }
}
