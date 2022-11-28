using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace JovemProgramadorMVC.Data.Repositorio
{

    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly JovemProgramadorContexto _jovemProgramadorContexto;
        public AlunoRepositorio(JovemProgramadorContexto jovemProgramadorContexto)
        {
            _jovemProgramadorContexto = jovemProgramadorContexto;
        }

        public void InserirAluno(AlunoModel alunos)
        {
            _jovemProgramadorContexto.Aluno.Add(alunos);
            _jovemProgramadorContexto.SaveChanges();
        }
        public List<AlunoModel> BuscarAlunos()
        {
            return _jovemProgramadorContexto.Aluno.ToList();
        }
        public AlunoModel BuscarId(int Id)
        {
            return _jovemProgramadorContexto.Aluno.FirstOrDefault(x => x.Id == Id);
        }

        public AlunoModel Atualizar(AlunoModel alunos)
        {
            AlunoModel AlunoDB = BuscarId(alunos.Id);
            

            AlunoDB.Nome = alunos.Nome;
            AlunoDB.Idade = alunos.Idade;
            AlunoDB.Contato = alunos.Contato;
            AlunoDB.Email = alunos.Email;
            AlunoDB.Cep = alunos.Cep;

            _jovemProgramadorContexto.Aluno.Update(AlunoDB);
            _jovemProgramadorContexto.SaveChanges();
            return AlunoDB;

        }

        public bool Apagar(int Id)
        {
            AlunoModel AlunoDB = BuscarId(Id);

         

            _jovemProgramadorContexto.Aluno.Remove(AlunoDB);
            _jovemProgramadorContexto.SaveChanges();

            return true;
        }
    }
}
