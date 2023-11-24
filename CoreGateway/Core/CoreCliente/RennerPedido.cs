using CoreGateway.Core.Interface;
using CoreGateway.DTO.InputModel;
using CoreGateway.DTO.ViewModel;
using CoreGateway.Entities;

namespace CoreGateway.Core.CoreCliente
{
    public class RennerPedido : Pedido, IPedidoCliente
    {
        public PedidoVO ConsultaPedido(string numeroPedido)
        {
            throw new NotImplementedException();
        }

        public PedidoVO CriarPedido(PedidoIn pedido)
        {
            throw new NotImplementedException();

        }
    }
}
