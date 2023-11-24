using CoreGateway.DTO.InputModel;
using CoreGateway.DTO.ViewModel;

namespace CoreGateway.Core.Interface
{
    public interface IPedidoCliente
    {
        PedidoVO CriarPedido(PedidoIn pedido);
        PedidoVO ConsultaPedido(string numeroPedido);
    }
}
