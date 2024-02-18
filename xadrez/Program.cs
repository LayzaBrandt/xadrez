
//Serão separadas em 3 camadas,
//1° → Camada de tabuleiro, elementos basicos do tabuleiro (tabuleiro,peças, posição, cor) - Não tem inteligência de jogo
//2° → Cama do jogo de xadrez (é que vai implementar as regras de jogo/peças)
//3° → Cama de aplicação (é o aplicativo que consome as duas camadas e interege com o usuário)

using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
                Console.ReadLine();
        }
    }
}
