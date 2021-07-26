using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public interface IServicosOrganizador
    {
        void CadastrarNovoOrganizador(Organizador organizador);
    }
}