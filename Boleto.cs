using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    class Boleto : Pagamento
    {
        public long codigoBarras;
        public int agencia;
        public int banco;

        public Boleto(double valorPagamento, string dataPagamento) : base(valorPagamento, dataPagamento)
        {
            this.valorPagamento = valorPagamento;
            this.dataPagamento = dataPagamento;
        }

        public void gerarCodigoBarras()
        {
            Random number = new Random();
            long codigoBarras = number.Next(number.Next(number.Next(number.Next(number.Next(number.Next())))));
            Console.WriteLine("Seu código de barras para pagamento é: "+ codigoBarras);        
        }
    }
}
