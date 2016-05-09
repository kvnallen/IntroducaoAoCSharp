using System;

namespace _03_OOComCSharp._02_Metodos
{
    public class Cachorro
    {

        public Cachorro()
        {
            EhLegal = true;
        }

        public bool EhLegal { get; private set; }

        public void Latir()
        {
            Console.WriteLine("Woof!");
        }
    }
}