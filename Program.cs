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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
