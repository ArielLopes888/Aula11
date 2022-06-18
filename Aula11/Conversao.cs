using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public abstract class Conversao
    {
        abstract public void ConversaoCompra(double valorCompra);
        abstract public void VerificarCompra(double valorCompra);
    }
    
}

/*
 EXEMPLO DE CÓDIGO DE CLASSE ABSTRATA
namespace aula11_controladores_de_acesso
{
    public abstract class Mamifero
    {
        public abstract void Andar();
        public abstract void Falar();
    }
}

*/