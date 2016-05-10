using Vida.Marvel.Entidades;

namespace ProjetoTeste.Entidades
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