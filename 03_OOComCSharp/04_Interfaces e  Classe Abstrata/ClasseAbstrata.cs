namespace _03_OOComCSharp._04_Interfaces
{
    public abstract class ClasseAbstrata
    {
        public string Nome { get; private set; }

        public virtual void Teste(bool teste)
        {
            //Poderá fazer override pelas classes que herdam
            //pois tem a palavra virtual
        }

        public void Teste()
        {
            //Não faz override
        }
    }
}
