namespace POSDesktop.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        // Exibe o preço formatado em Kwanza
        public string PrecoFormatado(string moeda = "AOA")
        {
            return Preco.ToString("N2") + " " + moeda;
        }
    }
}
