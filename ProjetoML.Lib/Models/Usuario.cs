namespace ProjetoML.Lib
{
    public class Usuario
    {
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string Senha { get; set; }
        public Usuario(int id, string nome, string email, string cpf, DateTime dataNasc, string senha)
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