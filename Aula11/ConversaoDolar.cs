using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public class ConversaoDolar : Conversao
    {

        private double cotacaoDaMoedaHoje = 4.57;
        const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500; 
        public double valorConvertido { get; set; }


        public override void ConversaoCompra(double valorEmReais)
        {
            valorConvertido = valorEmReais / cotacaoDaMoedaHoje;
        }

        public override void VerificarCompra(double valorEmReais)
        {
            ConversaoCompra(valorEmReais);

            string mensagem;
            if (valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $"A compra mínima permitida em dólar é de ${VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";
            }
            else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $"A compra máxima permitida em dólar é de ${VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
            }
            else
            {
                mensagem = $"Você pode comprar ${valorConvertido.ToString("F2")}";
            }
            Console.WriteLine(mensagem + Environment.NewLine);

        }
    }
}
