using System;

namespace _03_OOComCSharp._03_Heranca
{
    public class Animal
    {
        public decimal Peso { get; set; }

        public virtual void Mover()
        {
            Console.WriteLine("Movendo like a boss...");
        }
    }
}