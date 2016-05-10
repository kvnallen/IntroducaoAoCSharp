using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis

            var listaDePessoas = new List<string>
            {
                "Rafael",
                "Daivid",
                "Thiago",
                "Ricardo",
                "Gabriel",
                "João",
                "Fábio"
            };


            var lista2 = new[]
            {
                new { Nome = "Kevin", Idade = 28 },
                new { Nome = "2", Idade = 28 },
                new { Nome = "3", Idade = 28 },
            };
            #endregion

            #region SEM LINQ

            //for (int i = 0; i < listaDePessoas.Count; i++)
            //{
            //    Console.WriteLine("O nome da pessoa é : " + listaDePessoas[i]);
            //}
            #endregion

            #region COM LINQ

            #region Chain Method

            var listaSelecionada = listaDePessoas
                       .Select(nome => nome.ToUpper())
                       .Where(nome => nome.StartsWith("R"));
            #endregion

            #region Query Expression Syntax

            var listaQueryExpSyntax = from nome in listaDePessoas
                                      where nome.StartsWith("R")
                                      select nome.ToUpper();
            #endregion

            #endregion

            //Select - Método de Projeção/Criação/Conversão
            var autorizacoes =
                "1233567,212312321,3123123213,4123213213"
                .Split(',')
                .Select(autorizacao => int.Parse(autorizacao));


            //Meu software só aceita objetos do tipo "ObjetoComSelect"
            //O SAW me mandou em lista de strings, preciso converter
            //para o tipo obrigatório

            var autorizacoesObjeto =
                "888233567,212312321,3123123213,4123213213"
                .Split(',')
                .Select((autorizacao, indice) => new ObjetoComSelect
                {
                    Ordem = indice + 1,
                    Autorizacao = long.Parse(autorizacao)
                })
                //.Where(x => x.Autorizacao == 1233567)
                .ToList();


            //Any - Verifica se existe algum item que atenda
            //a condição
            var existeAutorizacaoTal = autorizacoesObjeto
                                            .Any(x => x.Autorizacao == 1233567);

            //OrderBy - Ordena por ordem crescente
            var autorizacoesEmOrdem = autorizacoesObjeto
                                            .OrderBy(x => x.Autorizacao);


            //OrderByDesc - Ordena por ordem decrescente
            var autorizacoesEmOrdemDesc = autorizacoesObjeto
                                           .OrderByDescending(x => x.Autorizacao);

            //All - Todos os itens devem atender a condição
            var todosOsItensAtendemACondicao = autorizacoesObjeto
                                                    .All(x => x.Autorizacao > 300000 && x.Autorizacao < 500000);

            //ToList - Converte em lista e executa
            var array = new[] { 5, 28, 24, 176, 9 };


            var listaEmArray = array.ToList();


            //Sum - Soma todos os valores
            var somaTotal = autorizacoesObjeto.Sum(x => x.Autorizacao);

            //Max
            var maiorAutorizacao = autorizacoesObjeto.Max(x => x.Autorizacao);

            //Min
            var menorValor = autorizacoesObjeto.Min(x => x.Autorizacao);

            //Count - Conta quantos itens tem
            var quantidade = autorizacoesObjeto
                                            .Count();

            //Count com filtro - Conta quantos itens com condição
            var quantidadeComFiltro = autorizacoesObjeto
                                            .Count(x => x.Autorizacao > 100000);

            //GroupBy - Agrupa os itens por determinado valor
            var pessoas = new[]{
                     new { Nome = "Kevin",      Idade = 15, Cargo = "Analista de Sistemas" },
                     new { Nome = "Gabriel",    Idade = 22, Cargo = "Técnico em Programação" },
                     new { Nome = "Ricardo",    Idade = 25, Cargo = "Técnico em Service Desk" },
                     new { Nome = "Rafael",     Idade = 27, Cargo = "Analista de Sistemas" },
                     new { Nome = "Daivid",     Idade = 28, Cargo = "Analista de Sistemas" },
                     new { Nome = "Fábio",      Idade = 60, Cargo = "Programador"},
                     new { Nome = "João Paulo", Idade = 28, Cargo = "Programador"}
                   };

            var grupoPessoas = pessoas.GroupBy(x => x.Cargo);



            /*
            * SelectMany
            */




            //Expressões Lambda: Como se fosse um método passado no parâmetro

            //LINQ: Conjunto de recursos/métodos para facilitar
            //      a vida do programador na busca, manipulação, etc...

            //X será  
            var listaDeIdades = lista2.Select(x => new { x.Idade });

            Console.Read();
        }
    }
}
