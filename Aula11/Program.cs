namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConversaoDolar conversaoDolar = new ConversaoDolar();
            Console.WriteLine("Informe o valor da compra em reais ou informe 0 para encerrar o programa");
            double.TryParse(Console.ReadLine(), out double valorCompraReais);
            while (valorCompraReais > 0)
            {
                conversaoDolar.VerificarCompra(valorCompraReais);
                Console.WriteLine("Informe o valor da compra em reais ou informe 0 para encerrar o programa");
                double.TryParse(Console.ReadLine(), out valorCompraReais);
            } 



        }
    }

}

/*
    CÓDIGO ANTERIOR


    public class Compra
    {
        double cotacaoDoDolarHoje = 4.97;
        const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
        public string converterRealParaDolar(double valorDaCompraEmReais)
        {
            double valorConvertido = valorDaCompraEmReais / cotacaoDoDolarHoje;
            string mensagem = "";
            if (valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $" A compra mínima permitida é de ${VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";
            }
            else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $" A compra máxima permitida é de ${VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
            }
            else
            {
                mensagem = $"Você pode comprar ${valorConvertido}";
            }
            return mensagem;
        }
    }
 */