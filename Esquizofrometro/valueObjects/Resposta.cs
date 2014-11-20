using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquizofrometro.valueObjects
{
    public class Resposta
    {
        public string respostatext;
        public int valor;

        public Resposta(string inRespostatxt, int inValor)
        {
            respostatext = inRespostatxt;
            valor = inValor;
        }

    }
}
