using System;

namespace Academia1.AcademiaRunning
{
    class DadosDosAlunos { 
    
        public static void Executar() {

            DadosAlunos aluno1 = new DadosAlunos();
            aluno1.Nome = "Robin";
            aluno1.Cpf = "123";
            aluno1.Dn = "13/12/2000";
            

            string dadosAluno1 = aluno1.ApresentarDados();
            Console.WriteLine(dadosAluno1);
            
            DadosAlunos aluno2 = new DadosAlunos();
            aluno2.Nome = "Mutano";
            aluno2.Cpf = "456";
            aluno2.Dn = "14/06/2000";

            string dadosAluno2 = aluno2.ApresentarDados();
            Console.WriteLine(dadosAluno2);

            DadosAlunos aluno3 = new DadosAlunos();
            aluno3.Nome = "Ravena";
            aluno3.Cpf = "789";
            aluno3.Dn = "15/11/2000";

            string dadosAluno3 = aluno3.ApresentarDados();
            Console.WriteLine(dadosAluno3);

            DadosAlunos aluno4 = new DadosAlunos();
            aluno4.Nome = "Estelar";
            aluno4.Cpf = "1011";
            aluno4.Dn = "26/08/2000";

            string dadosAluno4 = aluno4.ApresentarDados();
            Console.WriteLine(dadosAluno4);

            DadosAlunos aluno5 = new DadosAlunos();
            aluno5.Nome = "Cyborg";
            aluno5.Cpf = "1213";
            aluno5.Dn = "25/09/2000";

            string dadosAluno5 = aluno5.ApresentarDados();
            Console.WriteLine(dadosAluno5);
      
        }

    }
}
        