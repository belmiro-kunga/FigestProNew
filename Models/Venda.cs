using System;
using System.Collections.Generic;

namespace POSDesktop.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal Total { get; set; }

        // Calcula o valor total com IVA
        public decimal CalcularTotalComIVA(decimal iva)
        {
            return Total + (Total * iva);
        }

        // Exibe o total formatado em Kwanza
        public string TotalFormatado(string moeda = "AOA")
        {
            return Total.ToString("N2") + " " + moeda;
        }
    }
}
