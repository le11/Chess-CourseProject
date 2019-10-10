using System;
using tabuleiro;
using xadrez;

namespace xadrez__console_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 Tabuleiro tab = new Tabuleiro(8, 8);

                 tab.inserirPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.inserirPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                 tab.inserirPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                 Tela.imprimirTabuleiro(tab);

             }
             catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }
         }*/
            PosicaoXadrez p = new PosicaoXadrez('a', 5);

            Console.WriteLine(p.toPosicao());

        }
    }
}
