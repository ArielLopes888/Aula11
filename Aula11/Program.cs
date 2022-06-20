namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompraReais = 0;
            string escolha = "1";
            while (escolha == "1" || escolha == "2")
            {
                Console.WriteLine($"Informe qual conversão deseja fazer: {Environment.NewLine}1 - Dólar {Environment.NewLine}2 - Euro {Environment.NewLine}Digite qualquer outro valor para encerrar o programa.{Environment.NewLine}");
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    ConversaoDolar conversaoDolar = new ConversaoDolar();
                    Console.WriteLine($"{Environment.NewLine}CONVERSÃO EM DÓLAR");
                    Console.WriteLine("Informe o valor da compra em reais");
                    double.TryParse(Console.ReadLine(), out valorCompraReais);
                    while (valorCompraReais <= 0)
                    {
                        Console.WriteLine("Por favor, informe um valor em reais válido (acima de 0)");
                        double.TryParse(Console.ReadLine(), out valorCompraReais);
                    }
                    conversaoDolar.VerificarCompra(valorCompraReais);
                }
                else if (escolha == "2")
                {
                    ConversaoEuro conversaoEuro = new ConversaoEuro();


                    Console.WriteLine($"{Environment.NewLine}CONVERSÃO EM EURO");
                    Console.WriteLine("Informe o valor da compra em reais");
                    double.TryParse(Console.ReadLine(), out valorCompraReais);
                    while (valorCompraReais <= 0)
                    {
                        Console.WriteLine("Por favor, informe um valor em reais válido (acima de 0)");
                        double.TryParse(Console.ReadLine(), out valorCompraReais);
                    }
                    conversaoEuro.VerificarCompra(valorCompraReais);
                }
            }
            Console.WriteLine("Obrigada por utilizar nossos serviços!");
        }

    }

}