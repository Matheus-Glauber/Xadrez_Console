using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.tabuleiro
{
    class Peca
    {
        public Posicao Posic { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posic, Cor cor, Tabuleiro tab)
        {
            Posic = posic;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }
    }
}
