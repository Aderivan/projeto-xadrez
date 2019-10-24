using xadrez_console.xadrez;
using tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPecas(new Torre(tab, tabuleiro.Enum.Cor.Preta), new Posicao(0, 0));
            tab.ColocarPecas(new Torre(tab, tabuleiro.Enum.Cor.Preta), new Posicao(1, 3));
            tab.ColocarPecas(new Rei(tab, tabuleiro.Enum.Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);
        }
    }
}
