using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public class ServicosOrganizador : IServicosOrganizador
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public ServicosOrganizador(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            _repositorio.Adicionar(organizador);
        }
    }
}