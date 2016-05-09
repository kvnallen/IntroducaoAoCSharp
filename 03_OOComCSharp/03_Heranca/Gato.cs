using System;

namespace _03_OOComCSharp._03_Heranca
{
    public class Gato : Animal
    {
        public Gato()
        {
            Peso = 10;
            EhLegal = false;
        }

        public bool EhLegal { get; private set; }

        public void Miar()
        {
            Console.WriteLine("Miau! ^.^");
        }
    }
}