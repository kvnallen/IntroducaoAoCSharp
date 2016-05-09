using System;
using System.Diagnostics;

namespace _02_TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Interpolação de Strings

            //1 - Interpolação

            string nome = $"Kevin";
            string sobrenome = "Allen";

            //Exemplo com interpolação
            string resultado = $"Seu nome completo é : {nome} {sobrenome}";

            Console.WriteLine(resultado);

            #endregion

            #region 2 - Strings Literais

            string texto =
                "Mussum Ipsum, cacilds vidis litro abertis. " +
                "Ta deprimidis, eu conheço uma cachacis que pode " +
                "alegrar sua vidis.” Si num tem leite então bota " +
                "uma pinga aí cumpadi! Em pé sem cair, deitado sem dormir" +
                ", sentado sem cochilar e fazendo pose. " +
                "Leite de capivaris, leite de mula manquis.";

            //Não precisa concatenar
            // Evita concatenação (chato)
            // Evita criação de novos objetos

            string textoLiteral =
                @"Mussum Ipsum, cacilds vidis litro abertis. Vehicula non. Ut sed ex eros. 
                  Vivamus sit amet nibh non tellus tristique interdum. 
                  Quem num gosta di mé, boa gente num é. in elementis mé pra quem é amistosis quis leo. 
                  Sapien in monti palavris qui num significa nadis i pareci latim.

                  Si u mundo tá muito paradis? Toma um mé que o mundo vai girarzis! 
                  Si num tem leite então bota uma pinga aí cumpadi! 
                  Leite de capivaris, leite de mula manquis. 
                  Praesent malesuada urna nisi, quis volutpat erat hendrerit non. Nam vulputate dapibus.";


            #region Teste de desempenho

            var watch = Stopwatch.StartNew();

            for (int i = 0; i < 1000000000; i++)
            {
                var desempenho = "Mussum Ipsum, cacilds vidis litro abertis. " +
                                 "Ta deprimidis, eu conheço uma cachacis que pode " +
                                 "alegrar sua vidis.” Si num tem leite então bota " +
                                 "uma pinga aí cumpadi! Em pé sem cair, deitado sem dormir" +
                                 ", sentado sem cochilar e fazendo pose. " +
                                 "Leite de capivaris, leite de mula manquis.";
            }

            watch.Stop();


            var watchLiteral = Stopwatch.StartNew();

            for (int i = 0; i < 1000000000; i++)
            {
                var desempenho = @"Mussum Ipsum, cacilds vidis litro abertis.
                Ta deprimidis, eu conheço uma cachacis que pode 
                alegrar sua vidis.” Si num tem leite então bota 
                uma pinga aí cumpadi! Em pé sem cair, deitado sem dormir
                , sentado sem cochilar e fazendo pose.
                Leite de capivaris, leite de mula manquis.";
            }

            watchLiteral.Stop();

            Console.WriteLine($"Tempo concatenando: {watch.Elapsed}");
            Console.WriteLine($"Tempo com literal: {watchLiteral.Elapsed}");

            #endregion

            #endregion

            #region 3 - Conversões





            #region Números

            const string numeroEmString = "123456";

            int meuInteiro;

            //Converte direto no 
            meuInteiro = int.Parse(numeroEmString);

            //Vai tentar converter, se der erro não faz nada.
            int.TryParse(numeroEmString, out meuInteiro);

            //Mas como verificar se deu erro? :T
            if (int.TryParse(numeroEmString, out meuInteiro))
                Console.WriteLine("Número convertido com sucesso!");
            else
                Console.WriteLine("Ops! Esta string não é um inteiro em...");

            #endregion










            #region Datas

            const string dataString = "09/04/1992";

            DateTime dataConvertida;

            //Quando o formato está certinho ? :D
            dataConvertida = DateTime.Parse(dataString);
            dataConvertida = Convert.ToDateTime(dataString);

            //Criando uma data
            dataConvertida = new DateTime(year: 2016, month: 5, day: 10);

            //E quando recebo em string e tenho de criar :( ?
            var dataSplitted = dataString.Split('/');
            dataConvertida = new DateTime(year: int.Parse(dataSplitted[2]),
                                         month: int.Parse(dataSplitted[1]),
                                         day: int.Parse(dataSplitted[0]));

            Console.WriteLine(dataConvertida);

            #endregion




            /*
             * Resumão:
             
             * .Parse(x) : Converte o valor mas não verifica se o argumento é nulo
             * Convert.ToAlgumaCoisa() : Converte e verifica se o valor é nulo, quando você não tem certeza se o valor é certo
             */

            #endregion

            Console.Read();
        }
    }
}
