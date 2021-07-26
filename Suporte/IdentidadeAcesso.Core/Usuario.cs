namespace IdentidadeAcesso.Core
{
    public class Usuario
    {
        public LocatarioId Id { get; private set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario(LocatarioId id)
        {
            Id = id;
        }
    }
}