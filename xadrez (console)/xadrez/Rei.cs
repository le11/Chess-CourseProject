using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) :base (cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[this.Tab.Linhas, this.Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(Posicao.linha - 1, Posicao.coluna);
            if(Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Abaixo
            pos.definirValores(Posicao.linha +1, Posicao.coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Ne
            pos.definirValores(Posicao.linha - 1, Posicao.coluna +1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //No
            pos.definirValores(Posicao.linha - 1, Posicao.coluna-1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.definirValores(Posicao.linha, Posicao.coluna-1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direita
            pos.definirValores(Posicao.linha, Posicao.coluna+1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Se
            pos.definirValores(Posicao.linha + 1, Posicao.coluna+1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //So
            pos.definirValores(Posicao.linha + 1, Posicao.coluna-1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
