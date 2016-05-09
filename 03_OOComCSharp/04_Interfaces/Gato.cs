using System;

namespace _03_OOComCSharp._04_Interfaces
{
    public class Gato : IAnimal
    {
        public Gato()
        {
            Peso = 10;
            EhLegal = false;
        }

        public bool EhLegal { get; private set; }

        // As propriedades também são obrigatórias
        public decimal Peso { get; set; }

        public void Miar()
        {
            Console.WriteLine("Miau! ^.^");
        }

        public void Mover()
        {
            Console.WriteLine("Preciso dizer como vou me mover...");
        }
    }
}