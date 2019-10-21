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
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
