using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Data.Repositorio
{
    public class AlunoRepositorio: IAlunoRepositorio
    {
        private readonly JovemProgramadorContexto _jovemProgramadorContexto;

        public AlunoRepositorio(JovemProgramadorContexto jovemProgramadorContexto)
        {
            _jovemProgramadorContexto = jovemProgramadorContexto;
        }
        public void InserirAluno(AlunoModel alunos)
        {
            _jovemProgramadorContexto.Alunos.Add(alunos);
            _jovemProgramadorContexto.SaveChanges();
        }

    }
}
