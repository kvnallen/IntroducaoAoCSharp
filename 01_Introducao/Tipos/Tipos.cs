using System;
using System.Collections.Generic;

namespace _01_Introducao.Tipos
{

    public class ObjetoTeste
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class Tipos
    {
        public Tipos()
        {
            #region Tipos

            string minhaString = "String Comum";
            int valorInteiro = 10;
            decimal valorDecimal = 10.5m;
            double meuDouble = 10.5d;
            float meuFloat = 10.5f;
            object meuObjecto = new { Nome = "Ricardo" };
            byte meuByte = 1;
            char meuChar = 'K';

            //Identificação automática
            var meuArray = new[] { 1234 };

            //Inicializador de Objetos
            var listadeStrings = new List<string>
            {
                "Ricardo",
                "Gabriel",
                "Daivid",
                "Brasil"
            };
            #endregion

            #region Inicializador de Objetos

            //Sem incializador
            var objetoSemInicializador = new ObjetoTeste();
            objetoSemInicializador.Nome = "Ricardo";
            objetoSemInicializador.Idade = 26;

            //Com inicializador de objetos
            var objeto = new ObjetoTeste
            {
                Nome = "Ricardo",
                Idade = 26
            };
            #endregion
        }

        #region Propriedades

        //Propriedades públicas devem começar
        //com letra maíuscula
        public bool EhTipo { get; set; }

        //Propriedades privadas, começam com letra menúscula
        private bool ehTipo2;

        //Outra forma de convenção para variáveis privadas
        private bool _ehTipo3;

        public string Teste { get; set; }
        #endregion
    }
}