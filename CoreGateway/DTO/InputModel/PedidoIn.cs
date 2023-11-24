using System.ComponentModel.DataAnnotations;

namespace CoreGateway.DTO.InputModel
{
    public class PedidoIn
    {
        [Required]
        public int ClienteCodigo { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Destinatario { get; set; }
        public Dictionary<string, int> Produtos { get; set; }
    }
}
