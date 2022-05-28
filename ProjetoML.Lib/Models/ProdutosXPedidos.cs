namespace ProjetoML.Lib
{
    public class ProdutosXPedidos
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public ProdutosXPedidos(int id, int idProduto, int idPedido)
        {
            Id = id;
            IdProduto = idProduto;
            IdPedido = idPedido;
        }
    }
}