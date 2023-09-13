using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adicionar(Produto P);
        void Atualizar(Produto P);
        void Remover(Produto P);
        IList<Produto> Produtos();
    }
}
