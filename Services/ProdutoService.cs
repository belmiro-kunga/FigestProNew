using POSDesktop.Models;
using System.Collections.Generic;

namespace POSDesktop.Services
{
    public class ProdutoService
    {
        private List<Produto> produtos = new List<Produto>();

        public List<Produto> Listar() => produtos;
        public void Adicionar(Produto produto) => produtos.Add(produto);
        public void Remover(Produto produto) => produtos.Remove(produto);
    }
}
