using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    internal class CartaoDeDebito : Pagamento
    {
        public CartaoDeDebito(double valorPagamento, string dataPagamento) : base(valorPagamento, dataPagamento)
        {
        }

        public override double calcularValorFinal(Pagamento pagamento)
        {
            return pagamento.valorPagamento * 1.02;
        }
    }
}
