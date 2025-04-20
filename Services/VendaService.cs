using POSDesktop.Models;
using System.Collections.Generic;

namespace POSDesktop.Services
{
    public class VendaService
    {
        private List<Venda> vendas = new List<Venda>();

        public List<Venda> Listar() => vendas;
        public void Adicionar(Venda venda) => vendas.Add(venda);
    }
}
