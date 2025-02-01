using Microsoft.EntityFrameworkCore;
using Servidor.Models.Entidades;

namespace Servidor.Context
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos {get; set;}

        public DbSet<AlunoFunc> AlunoFuncs {get; set;}

        public DbSet<Departamento> Departamentos {get; set;}

        public DbSet<DepartamentoFuncionario> DepartamentoFuncionarios {get; set;}  

        public DbSet<Funcionario> Funcionarios {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da tabela de associação AlunoFunc (Relacionamento N:N)
            modelBuilder.Entity<AlunoFunc>()
                .HasKey(af => new { af.AlunoId, af.FuncionarioId });

            modelBuilder.Entity<AlunoFunc>()
                .HasOne(af => af.Aluno)
                .WithMany(a => a.AlunosFuncs)
                .HasForeignKey(af => af.AlunoId);

            modelBuilder.Entity<AlunoFunc>()
                .HasOne(af => af.Funcionario)
                .WithMany(f => f.AlunoFuncs)
                .HasForeignKey(af => af.FuncionarioId);

            // Configuração da tabela de associação DepartamentoFuncionario (Relacionamento N:1)
            modelBuilder.Entity<DepartamentoFuncionario>()
                .HasKey(df => df.DepartamentoFuncionarioId);

            modelBuilder.Entity<DepartamentoFuncionario>()
                .HasOne(df => df.Departamento)
                .WithMany(d => d.Departamentofuncionarios)
                .HasForeignKey(df => df.DepartamentoId);

            modelBuilder.Entity<DepartamentoFuncionario>()
                .HasOne(df => df.Funcionario)
                .WithOne(f => f.DepartamentoFuncionario)
                .HasForeignKey<DepartamentoFuncionario>(df => df.FuncionarioId);
        }
    }
}
