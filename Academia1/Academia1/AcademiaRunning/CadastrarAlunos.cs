using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia1.AcademiaRunning
{
    class CadastrarAlunos
    {
        public static void Executar()
        {
            //Ver se tem vaga
            Console.WriteLine("Cadastrar um novo aluno. ");

            const int alunos = 6;

            Console.WriteLine("Quantos alunos estão cadastrados? ");

            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int vagas);

            int totalvagas = (alunos - vagas);
            if (alunos - vagas >= 1)
            {
                Console.WriteLine("Temos vagas!");
                Console.WriteLine("Temos {0} vaga(s) para preencher!", totalvagas);
            }
            else if (alunos - vagas == 0)
            {
                Console.WriteLine("Todas as vagas foram preenchidas!");

                Console.WriteLine();

            }

            //Consultar CPF Cadastrado

            Console.WriteLine("Consultar CPF: ");
            int Cpf = int.Parse(Console.ReadLine());

            if (Cpf == 123 || Cpf == 456 || Cpf == 789 || Cpf == 1011 || Cpf == 1112)
            {

                Console.Write("O CPF {0} já está cadastrado! ", Cpf);
            }

            else
                Console.WriteLine("O CPF nº {0} não está cadastrado. ", Cpf);
            {
            }
            //Pagar a mensalidade

            Console.WriteLine(" O aluno deseja realizar o pagamento? S/N");
            string Pagamento = Console.ReadLine();

            if (Pagamento == "Sim")
            {
                Console.WriteLine("O Status de Pagamento foi alterado para: Pago");
                Console.WriteLine("O aluno está apto para realizar as aulas!");
            }
            else
                Console.WriteLine("Devido a falta de pagamento, " +
                                "o aluno não poderá realizar as aulas!");
            {

            }
            //Adicionar valor ao caixa

            const double caixa = 10000000.00;

            Console.Write("Registre o valor pago: R$  ");
            string valor = Console.ReadLine();
            double.TryParse(valor, out double recebido);

            double valorTotal = caixa + recebido;

            Console.WriteLine($"O valor total do caixa é R$ {valorTotal} reais.");

        }
    }

}
        



    



