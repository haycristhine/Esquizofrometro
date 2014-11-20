using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquizofrometro.valueObjects
{
    public class Pergunta
    {
        public string perguntatxt;
        public List<Resposta> lstrespostas;

        public Pergunta(string inPerguntatxt, List<Resposta> inLstrespostas)
        {
            perguntatxt = inPerguntatxt;
            lstrespostas = inLstrespostas;
        }


       
    }
}
