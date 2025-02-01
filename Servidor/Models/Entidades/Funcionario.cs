namespace Servidor.Models.Entidades
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string? Cargo { get; set; }

        public bool Status { get; set; }

        public string Turno { get; set; }

        //relacionamento

        public ICollection<AlunoFunc> AlunoFuncs{ get; set; }

        public DepartamentoFuncionario DepartamentoFuncionario { get; set; }
    }

}
    // Administrativo, Personal, Serviços.