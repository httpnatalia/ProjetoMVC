using JovemProgramadorMVC.Data.Mapeamento;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JovemProgramadorMVC.Data
{
    public class JovemProgramadorContexto : DbContext
    {
        public JovemProgramadorContexto(DbContextOptions<JovemProgramadorContexto> options): base(options)
        {
        }

        public DbSet<AlunoModel> Aluno { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapping());
        }
    } 
}
