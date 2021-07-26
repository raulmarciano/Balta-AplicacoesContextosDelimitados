using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Data
{
    public class OrganizadorRepositorio : IOrganizadorRepositorio
    {
        public void Adicionar(Organizador organizador)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivo()
        {
            var q = new List<Organizador>().AsQueryable();

            return q.Where(OrganizadorScope.TodosAtivos);
        }

        public IEnumerable<Organizador> OrganizadoresAtivoAnoCorrente(int ano)
        {
            var q = new List<Organizador>().AsQueryable();

            //Concatenar expressões
            //System.Linq.Expressions.Expression.And(expression1, expression2)

            return q.Where(OrganizadorScope.TodosAtivosAnoCorrente(DateTime.Now.Year));
        }
    }
}