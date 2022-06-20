using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public class ConversaoEuro : Conversao
    {

        private double cotacaoDaMoedaHoje = 5.41;
        const double VALOR_MINIMO_DE_COMPRA_EM_EURO = 100;
        const double VALOR_MAXIMO_DE_COMPRA_EM_EURO = 2500;
        public double valorConvertido { get; set; }


        public override void ConversaoCompra(double valorEmReais)
        {
            valorConvertido = valorEmReais / cotacaoDaMoedaHoje;
        }

        public override void VerificarCompra(double valorEmReais)
        {
            ConversaoCompra(valorEmReais);

            string mensagem;
            if (valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_EURO)
            {
                mensagem = $"A compra mínima permitida em EURO é de ${VALOR_MINIMO_DE_COMPRA_EM_EURO}";
            }
            else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_EURO)
            {
                mensagem = $"A compra máxima permitida em EURO é de ${VALOR_MAXIMO_DE_COMPRA_EM_EURO}";
            }
            else
            {
                mensagem = $"Você pode comprar ${valorConvertido.ToString("F2")}";
            }
            Console.WriteLine(mensagem + Environment.NewLine);
        }
    }
}