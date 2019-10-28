using xadrez;
using tabuleiro;
using xadrez_console.tabuleiro.Enum;
using excepcion;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.ColocarPecas(new Rei(tab, Cor.Branca), new Posicao(3, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
