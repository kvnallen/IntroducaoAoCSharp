using System;

namespace _03_OOComCSharp._03_Heranca
{
    public class Cachorro : Animal
    {
        public Cachorro()
        {
            Peso = 20;
            EhLegal = true;
        }

        public bool EhLegal { get; private set; }

        public void Latir()
        {
            Console.WriteLine("Woof!");
        }

        //Overload - sobrecarga
        public void Latir(bool latirBugado)
        {
            if (latirBugado)
                Console.WriteLine("Miau ?");
            else
                Console.WriteLine("Woof! :D");
        }
    }
}