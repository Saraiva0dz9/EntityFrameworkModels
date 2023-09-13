using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexto;

        public ProdutoDAOEntity()
        {
            this.contexto = new LojaContext();
        }
        public void Adicionar(Produto P)
        {
            contexto.Produtos.Add(P);
            contexto.SaveChanges();
        }

        public void Atualizar(Produto P)
        {
            contexto.Update(P);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return contexto.Produtos.ToList();
        }

        public void Remover(Produto P)
        {
            contexto.Remove(P);
            contexto.SaveChanges();
        }
    }
}
