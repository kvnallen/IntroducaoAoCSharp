using _03_OOComCSharp._03_Heranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOComCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Peixe();
            animal.Mover();

            var cachorro = new Cachorro();
            cachorro.Mover();

            Console.Read();
        }
    }
}
