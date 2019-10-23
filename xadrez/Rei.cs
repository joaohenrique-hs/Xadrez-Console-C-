using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
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
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna); // cima
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna); //baixo
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1); //esquerda
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1); //direita
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1); // cima esq
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1); //cima dir
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1); //baixo esq
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1); //baixo dir
            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}