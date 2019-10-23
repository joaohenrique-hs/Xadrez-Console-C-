using System;
using tabuleiro;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main()
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimePartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validaPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);
                        Console.WriteLine("\nTurno: " + partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                        Console.Write("\nDestino:" );
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validaPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
