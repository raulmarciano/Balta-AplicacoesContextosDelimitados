namespace Nucleo.Core
{
    public class NomeCompleto
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public NomeCompleto(string nome, string sobreNome)
        {
            Nome = nome;
            Sobrenome = sobreNome;
        }

        public string EscreverNome()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}