using System;
using tabuleiro;

namespace xadrez__console_
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

        }
    }
}
