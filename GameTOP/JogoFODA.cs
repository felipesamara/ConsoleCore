using GameTOP.Interface;
using GameTOP.lib;
using System;
namespace GameTOP
{
    public class JogoFODA
    {
        public readonly IJogador _jogadorA;
        public readonly IJogador _jogadorB;
        public JogoFODA(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciaJogo()
        {
           Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorB.Corre());
        }
    }
}