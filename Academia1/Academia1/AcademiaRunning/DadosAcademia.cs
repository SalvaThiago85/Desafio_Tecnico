using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.AcademiaRunning
{
    class DadosAcademia

    {
        public static void Executar()
           {
            string academia = "Running S/A";
            int vagas = 6;
            double caixa = 1000000.00;

            string nome1 = "Robin";
            string nome2 = "Ravena";
            string nome3 = "Estelar";
            string nome4 = "Mutano";
            string nome5 = "Cyborg";

            Console.WriteLine($"Academia {academia} ");
            Console.WriteLine($"Quantidade de vagas: {vagas}");
            Console.WriteLine($"Total em caixa: R$ {caixa} reais");
            Console.WriteLine("Lista de alunos: {0}, {1}, {2}, {3}, {4}",
                    nome1, nome2, nome3, nome4, nome5);



        }

    }
}
