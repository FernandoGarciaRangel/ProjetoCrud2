namespace Servidor.Models.Entidades
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        //
        public ICollection<DepartamentoFuncionario> Departamentofuncionarios { get; set; }

    }
}
