using System.Net.Http.Headers;
using tabuleiro;

namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao? posicao { get; set; }
        public Cor cor { get; protected set; } //protected → só vai ser acessada por ela mesma e pela subclasses dela;
        public int qteMovimentos {  get; protected set; }
        public Tabuleiro? tab {  get; protected set; }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;//a peça quando acaba de ser criada no construtor ela ainda não teve movimento, então inicia com 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
