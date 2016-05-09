using System;
using System.Collections.Generic;

namespace _04_EstruturasDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipo = "Gato";

            #region IF / ELSE IF / ELSE

            if (tipo == "Gato")
            {
                Console.WriteLine("É um gato.");
            }
            else if (tipo == "Cachorro")
            {
                Console.WriteLine("É um cachorro.");
            }
            else
            {
                Console.WriteLine("Nem um nem outro.");
            }

            //Console.Read();

            #endregion

            #region SWITCH/CASE

            switch (tipo)
            {
                case "Gato":
                    Console.WriteLine("É um gato.");
                    break;
                case "Cachorro":
                    Console.WriteLine("É um cachorro.");
                    break;
                default:
                    Console.WriteLine("Nem um nem outro.");
                    break;
            }

            #endregion

            #region Loops e Iterações

            var arrayDeAnimais = new[] { "cachorro", "peixe", "gato", "bode" };
            var quantidadeAnimais = arrayDeAnimais.Length;

            #region FOR

            //for (int indice = 0;
            //    //Declaração
            //    indice < quantidadeAnimais;
            //    //Condição
            //    indice++ // O que acontecerá se a condição for verdadeira
            //    )
            //{
            //    Console.WriteLine(arrayDeAnimais[indice]);
            //}

            #endregion

            #region FOREACH

            //foreach (var animal in arrayDeAnimais)
            //{
            //    Console.WriteLine(animal);
            //}

            #endregion

            #region WHILE

            //int contador = 0;
            //while (contador < quantidadeAnimais)
            //{
            //    Console.WriteLine(arrayDeAnimais[contador]);
            //    contador++;
            //}

            #endregion

            #region DO WHILE

            //int contador = 0;

            //do
            //{
            //    Console.WriteLine(arrayDeAnimais[contador]);
            //    contador++;

            //} while (arrayDeAnimais[contador] != "gato"); // Sim, tenho preconceito contra gatos

            #endregion

            #endregion

            Console.Read();
        }
    }
}
