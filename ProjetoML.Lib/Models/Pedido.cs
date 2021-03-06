namespace ProjetoML.Lib.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdTransportadora { get; set; }
        public Transportadora Transportadora { get; set; }
        public List<ProdutosXPedidos> ProdutosXPedidos { get; set; }
        public Pedido(int id, DateTime dataPedido,string statusPedido, int idUsuario, int idTransportadora)
        {
            Id = id;
            DataPedido = dataPedido;
            StatusPedido = statusPedido;
            IdUsuario = idUsuario;
            IdTransportadora = idTransportadora;
        }
    }
}