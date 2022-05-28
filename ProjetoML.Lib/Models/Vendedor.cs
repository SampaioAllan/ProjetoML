namespace ProjetoML.Lib.Models
{
    public class Vendedor : Pessoa
    {
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produto> Produto { get; set; }
        public Vendedor(int id, string nome, string email, string cnpj, DateTime dataCadastro) : base(id, nome, email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CNPJ = cnpj;
            DataCadastro = dataCadastro;
        }
    }
}