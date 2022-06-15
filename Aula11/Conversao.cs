using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public abstract class Conversao
    {
        /*
        public double valorDaCompraEmReais;
        public double valorMinimoDaCompra;
        public double valorMaximoDaCompra;
        public abstract double cotacaoDaMoedaHoje { get; set; }
        */

        abstract public void ConversaoMinima();
        abstract public void ConversaoMaxima();
        abstract public void ConversaoCompra();
    }

    
}


/*
namespace aula11_controladores_de_acesso
{
    public abstract class Mamifero
    {
        public abstract void Andar();
        public abstract void Falar();
    }
}


namespace aula11_controladores_de_acesso
{
    public class Humano : Mamifero
    {
        private string nome;
        public string Nome {
            get { 
                return nome; 
            }
            set { 
                nome = value; 
            }
        }

        public override void Andar()
        {
            Console.WriteLine("Pernas");
        }
        public override void Falar()
        {
            Console.WriteLine("Olá");
        }


    }
}

 */