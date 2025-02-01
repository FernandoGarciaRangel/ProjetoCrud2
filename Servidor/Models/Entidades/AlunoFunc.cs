namespace Servidor.Models.Entidades
{
    public class AlunoFunc
    {

        public int AlunoId { get; set; } 
        
        public Aluno Aluno { get; set; }

        public int FuncionarioId { get; set;}

        public Funcionario Funcionario { get; set;}
    }
}
