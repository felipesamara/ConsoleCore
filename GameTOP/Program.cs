using GameTOP.lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new JoagadorA(), new JogadorB());
            jogo.IniciaJogo();
        }
    }
}
