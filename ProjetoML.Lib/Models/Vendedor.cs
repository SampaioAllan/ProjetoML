namespace ProjetoML.Lib
{
    public class Vendedor
    {
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
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