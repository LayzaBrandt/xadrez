
//Serão separadas em 3 camadas,
//1° → Camada de tabuleiro, elementos basicos do tabuleiro (tabuleiro,peças, posição, cor) - Não tem inteligência de jogo
//2° → Cama do jogo de xadrez (é que vai implementar as regras de jogo/peças)
//3° → Cama de aplicação (é o aplicativo que consome as duas camadas e interege com o usuário)

using Tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.WriteLine();
        }
    }
}
