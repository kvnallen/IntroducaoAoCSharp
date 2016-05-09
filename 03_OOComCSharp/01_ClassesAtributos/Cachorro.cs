namespace _03_OOComCSharp._01_ClassesAtributos
{
    public class Cachorro
    {

        public Cachorro()
        {
            EhLegal = true;
        }

        public bool EhLegal { get; private set; }
    }
}