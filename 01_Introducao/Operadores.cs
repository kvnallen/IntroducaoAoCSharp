using _01_Introducao.Tipos;

namespace _01_Introducao
{
    public class Calculadora
    {
        public Calculadora()
        {
            var var1 = 1;
            var var2 = 2;

            var igualdade = (var1 == var2);

            var diferenca = (var1 != var2);

            //Maior ou igual
            if (var2 >= var1)
            {

            }

            //Maior
            if (var2 > var1)
            {

            }

            //Menor igual
            if (var2 <= var1)
            {

            }

            var meuObjeto = new ObjetoTeste();
            string nome;
            ObjetoTeste meuObjeto2;

            if (meuObjeto == null)
                meuObjeto2 = new ObjetoTeste();

            meuObjeto2 = meuObjeto ?? new ObjetoTeste();

            //Sem operador condicional
            if (meuObjeto != null)
                nome = meuObjeto.Nome;

            // com Operador condicional
            nome = meuObjeto?.Nome;

        }

        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        public int Subtracao(int x, int y)
        {
            return x - y;
        }

        public int Divisao(int x, int y)
        {
            return x / y;
        }

        public int Modulo(int x = 20, int y = 10)
        {
            return x % y;
        }
    }
}