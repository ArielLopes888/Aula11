using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public class ConversaoDolar : Conversao
    {

        private double cotacaoDaMoedaHoje;
        private double valorDaCompraEmReais;
        private double valorConvertido;
        public double CotacaoDaMoedaHoje
        {
            get
            {
                return cotacaoDaMoedaHoje;
            }
            set
            {
                cotacaoDaMoedaHoje = value;
            }
        }

        /*
        public override double cotacaoDaMoedaHoje 
        {
            get; set;
        }
        */

        public override void ConversaoMaxima()
        {

        }
        public override void ConversaoMinima()
        {

        }
        public override void ConversaoCompra()
        {
            valorConvertido = valorDaCompraEmReais/cotacaoDaMoedaHoje;
        }
    }
}
