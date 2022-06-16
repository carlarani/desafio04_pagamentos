using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    internal class CartaoDeCredito : Pagamento
    {
        public CartaoDeCredito(double valorPagamento, string dataPagamento) : base(valorPagamento, dataPagamento)
        {
        }

        public override double calcularValorFinal(Pagamento pagamento)
        {
            double valorFinal = pagamento.valorPagamento * 1.04;
            return valorFinal;
        }
    }
}
