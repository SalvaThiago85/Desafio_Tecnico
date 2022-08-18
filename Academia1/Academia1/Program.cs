using System;
using System.Collections.Generic;
using Academia.AcademiaRunning;
using Academia1.AcademiaRunning;

namespace Academia1
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new Central(new Dictionary<string, Action>() {

                {"Dados da Academia - Academia Running", DadosAcademia.Executar},
                {"Dados dos Alunos - Academia Running", DadosDosAlunos.Executar},
                {"Cadastrar Alunos - Academia Running", CadastrarAlunos.Executar},

                
                           });

            central.SelecionarEExecutar();
        }
    }
}