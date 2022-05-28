namespace ProjetoML.Lib.Models
{
    public class Usuario : Pessoa
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string Senha { get; set; }
        public List<Pedido> Pedido { get; set; }
        public Usuario(int id, string nome, string email, string cpf, DateTime dataNasc, string senha) :base(id, nome, email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            Senha = senha;
        }
    }
}