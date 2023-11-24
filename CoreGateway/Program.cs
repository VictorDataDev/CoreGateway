// See https://aka.ms/new-console-template for more information
using CoreGateway.Core.CoreCliente;
using CoreGateway.DTO.Enum;
using CoreGateway.DTO.InputModel;
using CoreGateway.DTO.ViewModel;
using CoreGateway.Gateway;
using CoreGateway.Gateway.Infra;

Console.WriteLine("Carregando.....");

var clientBase = new Dictionary<string, Type>();
clientBase.Add(((EnumCliente)1).ToString(), new CeaPedido().GetType());
clientBase.Add(((EnumCliente)2).ToString(), new RennerPedido().GetType());
clientBase.Add(((EnumCliente)3).ToString(), new RiachueloPedido().GetType());

var registry = new ClientServiceRegistry();
foreach (var cliente in clientBase)
    registry.RegisterClientService(cliente.Key, cliente.Value);

Console.WriteLine("Iniciando.....");

Console.WriteLine("Programa Iniciado em " + DateTime.Now.ToString("dd/MM/yyyy hh:mm"));

var produtos = new Dictionary<string, int>();
produtos.Add("Palheta Roxa", 10);
produtos.Add("Palheta Azul", 10);

var mock = new PedidoIn
{
    ClienteCodigo = 3,
    Cep = "06437240",
    Complemento = "Casa 4",
    Destinatario = "Victor",
    Produtos = produtos
};

PedidoVO pedidoGerado = new PedidoGateway(registry).CriarPedido(mock);

Console.WriteLine(pedidoGerado.ToString());

Console.WriteLine("Finalizado");
Console.WriteLine("Obrigado =)");

