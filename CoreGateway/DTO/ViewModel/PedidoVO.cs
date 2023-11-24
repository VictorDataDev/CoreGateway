
namespace CoreGateway.DTO.ViewModel
{
    public class PedidoVO
    {
        public string NumeroPedido { get; set; }
        public string Endereco { get; set; }
        public string Destinatario { get; set; }
        public decimal ValorPedido { get; set; }
        public override string ToString()
        {
            return $"NumeroPedido: {NumeroPedido}, Endereço: {Endereco}, Destinatario: {Destinatario}, valor do Pedido: R${ValorPedido}";
        }
    }
}
