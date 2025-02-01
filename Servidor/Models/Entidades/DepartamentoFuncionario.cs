namespace Servidor.Models.Entidades
{
    public class DepartamentoFuncionario
    {
        public int DepartamentoFuncionarioId { get; set; }

        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set;}

        public int FuncionarioId { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
