using System;

namespace _03_OOComCSharp._02_Metodos
{
    public class Gato
    {
        public Gato()
        {
            EhChato = true;
        }

        public bool EhChato { get; private set; }

        public void Miar()
        {
            Console.WriteLine("Miau! ^.^");
        }
        
    }
}