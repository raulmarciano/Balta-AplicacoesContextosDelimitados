using System;
using Nucleo.Core;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public OrganizadorId Id { get; private set; }
        public string Nome { get; private set; }
        public NomeCompleto Responsavel { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        
        public Organizador(string nome, NomeCompleto responsavel, OrganizadorId id)
        {
            Id = id;
            Nome = nome;
            Responsavel = responsavel;
        }
    }
}