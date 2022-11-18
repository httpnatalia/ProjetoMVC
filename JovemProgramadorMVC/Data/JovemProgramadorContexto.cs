using JovemProgramadorMVC.Data.Mapeamento;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Data
{
    public class JovemProgramadorContexto : DbContext
    {
        public JovemProgramadorContexto(DbContextOptions<JovemProgramadorContexto> options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapping());
        }

        public DbSet<AlunoModel> Alunos { get; set; }


        } 
}
