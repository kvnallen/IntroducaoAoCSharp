using System;

namespace _03_OOComCSharp._03_Heranca
{
    public class Peixe : Animal
    {
        public override void Mover()
        {
            Console.WriteLine("Não posso me mover como os outros, mas posso nadar. :D");
        }
    }
}