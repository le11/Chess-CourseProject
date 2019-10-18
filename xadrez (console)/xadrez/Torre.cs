using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
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
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha--;
            }

            //Abaixo
            pos.definirValores(Posicao.linha + 1, Posicao.coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha++;
            }

            //Esquerda
            pos.definirValores(Posicao.linha, Posicao.coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna--;
            }

            //Direita
            pos.definirValores(Posicao.linha, Posicao.coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna++;
            }

            return mat;
        }
        
    }
    }

