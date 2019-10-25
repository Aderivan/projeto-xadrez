using xadrez;
using tabuleiro;
using excepcion;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez xadrez = new PosicaoXadrez('b', 1);
            Console.WriteLine(xadrez);

            Console.WriteLine(xadrez.toPosicao());
        }
    }
}
