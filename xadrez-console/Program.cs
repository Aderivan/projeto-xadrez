using xadrez_console.xadrez;
using tabuleiro;
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

                tab.ColocarPecas(new Torre(tab, tabuleiro.Enum.Cor.Preta), new Posicao(0, 0));
                tab.ColocarPecas(new Torre(tab, tabuleiro.Enum.Cor.Preta), new Posicao(1, 3));
                tab.ColocarPecas(new Rei(tab, tabuleiro.Enum.Cor.Preta), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExcepcion e)
            {
                Console.WriteLine(e.Message);   
            }
        }
    }
}
