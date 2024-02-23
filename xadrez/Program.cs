
//Serão separadas em 3 camadas,
//1° → Camada de tabuleiro, elementos basicos do tabuleiro (tabuleiro,peças, posição, cor) - Não tem inteligência de jogo
//2° → Cama do jogo de xadrez (é que vai implementar as regras de jogo/peças)
//3° → Cama de aplicação (é o aplicativo que consome as duas camadas e interege com o usuário)

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidadeDeXadrez partida = new PartidadeDeXadrez();
                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();

                        Tela.imprimirPartida(partida);
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
