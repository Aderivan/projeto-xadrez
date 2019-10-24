﻿using tabuleiro;
using xadrez_console.tabuleiro.Enum;

namespace xadrez_console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
