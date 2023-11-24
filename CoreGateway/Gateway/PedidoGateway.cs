using CoreGateway.DTO.Enum;
using CoreGateway.DTO.InputModel;
using CoreGateway.DTO.ViewModel;
using CoreGateway.Gateway.Infra;

namespace CoreGateway.Gateway
{
    public class PedidoGateway
    {
        private readonly ClientServiceRegistry _clientServiceRegistry;
        public PedidoGateway(ClientServiceRegistry clientServiceRegistry)
        {
            _clientServiceRegistry= clientServiceRegistry;
        }
        public PedidoVO CriarPedido(PedidoIn pedido)
        {
            var gateway = _clientServiceRegistry.GetClientService(pedido.ClienteCodigo);

            if (gateway != null)
                return gateway.CriarPedido(pedido);
            else
            {
                // Cliente não encontrado, trate isso conforme necessário
                throw new ArgumentException($"Client '{(EnumCliente)pedido.ClienteCodigo}' not registered.");
            }
        }
    }
}
