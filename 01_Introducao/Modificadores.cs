namespace _01_Introducao
{
    public class Modificadores
    {
        //Acessível apenas dentro da própria classe
        private string VariavelPrivada;

        //Acesso à todos
        public string VariavelPublica;

        // Só é acessada por classes que herdaram
        protected string VariavelProtegida;

        //Acessada apenas no próprio projeto
        internal string VariavelInterna;
    }
}