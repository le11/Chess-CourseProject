using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {

        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(cor, tab)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool TorreTesteRoque(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.qtdeMovimentos == 0;
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
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Abaixo
            pos.definirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Ne
            pos.definirValores(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //No
            pos.definirValores(Posicao.linha - 1, Posicao.coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.definirValores(Posicao.linha, Posicao.coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direita
            pos.definirValores(Posicao.linha, Posicao.coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Se
            pos.definirValores(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //So
            pos.definirValores(Posicao.linha + 1, Posicao.coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //#JogadadaEspecial ROQUE
            if (qtdeMovimentos == 0 && !partida.xeque)
            {
                //#Roque PEQUENO
                Posicao posT1 = new Posicao(Posicao.linha, Posicao.coluna + 3);
                if (TorreTesteRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna + 2);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna + 2] = true;
                    }
                }

                //#Roque GRANDE
                Posicao posT2 = new Posicao(Posicao.linha, Posicao.coluna - 4);
                if (TorreTesteRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna - 2);
                    Posicao p3 = new Posicao(Posicao.linha, Posicao.coluna - 3);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null && Tab.peca(p3) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}
