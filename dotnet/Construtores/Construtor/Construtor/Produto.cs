using System.Globalization;
namespace Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco { get; private set; }//autoprop
        public int Quantidade { get; private set; }//autoprop
        private string _teste;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {

        }

        public string Teste // Exemplo de propriedade
        {
            get { return _teste; }
            set { if (value != null && value.Length > 1) _teste = value; }
        }

        public Produto(string nome, double preco)
        {
            // Exemplo de sobrecarga
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Não necessario
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}