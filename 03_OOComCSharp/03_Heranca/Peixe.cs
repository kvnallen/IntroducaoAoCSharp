using System;

namespace _03_OOComCSharp._03_Heranca
{
    public class Peixe : Animal
    {
        public Peixe() : base(30)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"Peso {base.Peso} Não posso me mover como os outros, mas posso nadar. :D");
        }
    }
}