using CoreGateway.Core.Interface;
using CoreGateway.DTO.Enum;

namespace CoreGateway.Gateway.Infra
{
    public class ClientServiceRegistry
    {
        private readonly Dictionary<string, Type> _clientServices = new Dictionary<string, Type>();
        public void RegisterClientService(string clientId, Type serviceType)
        {
            _clientServices.Add(clientId, serviceType);
        }

        public IPedidoCliente GetClientService(int clientId)
        {
            if (_clientServices.TryGetValue(((EnumCliente)clientId).ToString(), out var serviceType))
            {
                return (IPedidoCliente)Activator.CreateInstance(serviceType);
            }

            return null; // Ou lançar uma exceção se o cliente não estiver registrado
        }
    }

}
