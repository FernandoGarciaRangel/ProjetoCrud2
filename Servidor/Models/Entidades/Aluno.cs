namespace Servidor.Models.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set;}

        public string Cpf { get; set; }

        public string Status { get; set; }

        public ICollection<AlunoFunc> AlunosFuncs { get; set; }
    }
}
