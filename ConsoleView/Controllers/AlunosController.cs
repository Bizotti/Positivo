using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AlunosController
    {
        List<Aluno> tabelaAlunos = new List<Aluno>();

        public void Inserir(Aluno a)
        {
            tabelaAlunos.Add(a);
        }

        public List<Aluno> ListarTodos()
        {
            return tabelaAlunos;
        }
            
    }


}
