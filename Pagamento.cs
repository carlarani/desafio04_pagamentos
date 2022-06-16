using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    class Pagamento
    {
        public double valorPagamento;
        public string dataPagamento;
        int opcaoPagamento;
        
        public Pagamento(double valorPagamento, string dataPagamento)
        {
            this.valorPagamento = valorPagamento;
            this.dataPagamento = dataPagamento;
        }

        public int escolherMeioPagamento()
        {
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão de Crédito");
            Console.WriteLine("3 - Cartão de Débito");
            opcaoPagamento = Convert.ToInt32(Console.ReadLine());
            return opcaoPagamento;
        }
        public virtual double calcularValorFinal(Pagamento pagamento)
        {
            return pagamento.valorPagamento;
        }
    }
    
    public class Teste
    {
        public static void Main (string[] args)
        {
            Pagamento pagamento = new Pagamento(100, "16/06/2022");


            switch (pagamento.escolherMeioPagamento())
            {
                case 1:
                    Boleto boleto = new Boleto (pagamento.valorPagamento, pagamento.dataPagamento);
                    boleto.calcularValorFinal(pagamento);
                    Console.WriteLine($"O valor final do seu pagamento ficou R${boleto.valorPagamento}.");
                    boleto.gerarCodigoBarras();
                    break;
                case 2:
                    CartaoDeCredito cdc = new CartaoDeCredito (pagamento.valorPagamento, pagamento.dataPagamento);
                    Console.WriteLine($"O valor final do seu pagamento ficou R${cdc.calcularValorFinal(pagamento)}.");
                    break;
                case 3:
                    CartaoDeDebito cdd = new CartaoDeDebito(pagamento.valorPagamento, pagamento.dataPagamento);
                    Console.WriteLine($"O valor final do seu pagamento ficou R${cdd.calcularValorFinal(pagamento)}.");
                    break;


            }
            
            


        }
    }
}
