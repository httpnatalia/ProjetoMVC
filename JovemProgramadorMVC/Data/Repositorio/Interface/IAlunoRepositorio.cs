using JovemProgramadorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        void InserirAluno(AlunoModel alunos);
        List<AlunoModel> BuscarAlunos();
        AlunoModel BuscarId(int Id); 
        AlunoModel Atualizar(AlunoModel alunos);
        bool Apagar(int Id);


    }
}
