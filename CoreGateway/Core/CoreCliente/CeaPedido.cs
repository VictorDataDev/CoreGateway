using CoreGateway.Core.Interface;
using CoreGateway.DTO.InputModel;
using CoreGateway.DTO.ViewModel;
using CoreGateway.Entities;

namespace CoreGateway.Core.CoreCliente
{
    public class CeaPedido : Pedido, IPedidoCliente
    {
        internal readonly decimal taxaCeaPedidos = 0.5M;
        public PedidoVO ConsultaPedido(string numeroPedido)
        {
            throw new NotImplementedException();
        }

        public PedidoVO CriarPedido(PedidoIn pedido)
        {
            this.CriarBasePedido(pedido.Destinatario, pedido.Cep, pedido.Complemento, pedido.Produtos);
            this.CalcularValorPedido();

            return new PedidoVO
            {
                Destinatario = Destinatario,
                Endereco = Endereco,
                NumeroPedido = NumeroPedido,
                ValorPedido = ValorPedido,
            };
        }
        protected override void CalcularValorPedido()
        {
            var valorPedido = 0M;

            for (int i = 0; i < Produtos.Count; i++)
            {
                valorPedido += Produtos.ElementAt(i).Value * taxaBasePedido * taxaCeaPedidos;
            }

            ValorPedido = valorPedido;
        }
        protected override string GerarNumeroPedido()
        {
            return $"P-CEA-{new Random().Next(10000)}";
        }
    }
}
