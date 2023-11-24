
namespace CoreGateway.Entities
{
    public class Pedido
    {
        internal readonly decimal taxaBasePedido = 3.5M;
        public Guid Id { get; internal set; }
        public string NumeroPedido { get; internal set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Destinatario { get; set; }
        public Dictionary<string, int> Produtos { get; set; }
        public decimal ValorPedido { get; internal set; }
        public Pedido()
        {
                
        }
        public Pedido(string nome, string cep, string complemento, Dictionary<string, int> produtos)
        {
            CriarBasePedido(nome, cep, complemento, produtos);
        }

        internal void CriarBasePedido(string nome, string cep, string complemento, Dictionary<string, int> produtos)
        {
            Id = Guid.NewGuid();
            NumeroPedido = this.GerarNumeroPedido();
            Endereco = this.ConsultarEndereco(cep);
            Complemento = complemento;
            Cep = cep;
            Destinatario = nome;
            Produtos = produtos;
        }

        protected virtual string GerarNumeroPedido()
        {
            return $"P{new Random().Next(10000)}";
        }

        internal string ConsultarEndereco(string cep)
        {
            return $"Seu endereço tem o CEP: {cep}";
        }
        protected virtual void CalcularValorPedido()
        {
            var valorPedido = 0M;

            for (int i = 0; i < Produtos.Count; i++)
            {
                valorPedido += Produtos.ElementAt(i).Value * taxaBasePedido;
            }

            ValorPedido = valorPedido;
        }
    }
}
