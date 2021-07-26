namespace IdentidadeAcesso.Core
{
    public class Locatario
    {
        public LocatarioId Id { get; private set; }
        public string Nome { get; set; }

        public Locatario(LocatarioId id)
        {
            Id = id;
        }

        public Usuario NovoUsuario()
        {
            return new Usuario(Id);
        }
    }
}