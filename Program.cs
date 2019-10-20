using System;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            Tabuleiro tab = new Tabuleiro(8,8);
            p = new Posicao(3, 4);
            Console.WriteLine("Posição: " + p);
        }
    }
}
