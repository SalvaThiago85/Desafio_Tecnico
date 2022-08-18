using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Academia1.AcademiaRunning
{
    class DadosAlunos

    {
        public string Nome;
        public string Cpf;
        public string Dn;
        enum Pagamento { Pago, Apagar };
        Pagamento statusPg = (Pagamento)0;

        public string ApresentarDados()
        {
            return string.Format(
                               $"Aluno: {Nome} / CPF: {Cpf} / Status de Pagamento: {statusPg} / DN: {Dn}");
        }
        public void Dadospessoais() { 
            Console.WriteLine(ApresentarDados());

        }
    class DadosAcademia
    {
        public double Pago;
        public double Caixa;
       // public double Adicionar() {
              //  return string.Format, (
                   // $"Valor pago é {Pago}, somando o valor total do caixa R$ {Caixa} reais.");
    }
    
            
        } 

    

    }




