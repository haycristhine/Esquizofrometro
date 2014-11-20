using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquizofrometro.valueObjects
{
    public class Perguntas
    {
        public List<Pergunta> lstperguntas;


        public static List<Pergunta> generatePerguntas()
        {
            //-----------------------------------------------------------------------------
            List<Pergunta> lstreturn = new List<Pergunta>();
            string pergunta = "Você costuma falar sozinho?";
            List<Resposta> lstrespostas = new List<Resposta>();

           
            lstrespostas.Add(new Resposta("Só às vezes", 7));
            lstrespostas.Add(new Resposta("Acho que já falei umas 2 ou 3 vezes", 4));
            lstrespostas.Add(new Resposta("Não. Nunca", 1));
            lstrespostas.Add(new Resposta("Sim. Sempre", 10));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Você, às vezes, conversa com seu computador?";
            lstrespostas.Add(new Resposta("Não. Nunca", 1));
            lstrespostas.Add(new Resposta("Sim. E ele me entende", 10));
            lstrespostas.Add(new Resposta("Só às vezes (quando ele me ouve)", 7));
            lstrespostas.Add(new Resposta("Só quando estou com raiva", 4));
           

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------


            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Costuma falar palavrões?";
          
            lstrespostas.Add(new Resposta("Sim, pois estou sempre irritado", 7));
            lstrespostas.Add(new Resposta("Só quando alguém me irrita", 4));
            lstrespostas.Add(new Resposta("Claro! A cada 10 palavras 11 são", 10));
            lstrespostas.Add(new Resposta("Não. Sou evangélico", 1));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Costuma perguntar coisas para uma terceira pessoa que não existe no local?";
          
            lstrespostas.Add(new Resposta("Quando tenho dúvidas só", 7));
            lstrespostas.Add(new Resposta("Existe sim, ela é verde e usa chapéu", 10));
            lstrespostas.Add(new Resposta("Não", 1));
            lstrespostas.Add(new Resposta("Quem?", 4));
          

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Que tipo de música costuma ouvir?";
            lstrespostas.Add(new Resposta("Quanto mais barulho melhor", 10));
            lstrespostas.Add(new Resposta("Não precisa nem ter letra", 7));
            lstrespostas.Add(new Resposta("Qualquer uma serve", 4));
            lstrespostas.Add(new Resposta("Gosto de entender a letra", 1));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Como vc é com as pessoas?";
            lstrespostas.Add(new Resposta("Indiferente", 10));
            lstrespostas.Add(new Resposta("Tenho vários amigos e gosto deles", 1));
            lstrespostas.Add(new Resposta("Sou anti-social", 7));
            lstrespostas.Add(new Resposta("Não faço nada demais", 5));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Até que horas fica acordado?";
         
            lstrespostas.Add(new Resposta("até as 10h", 3));
            lstrespostas.Add(new Resposta("Sou um zumbi", 10));
            lstrespostas.Add(new Resposta("até as 12h", 5));
            lstrespostas.Add(new Resposta("Até as 9h", 1));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Se encontrasse um Alienígena no quintal de sua casa, o que faria?";

            lstrespostas.Add(new Resposta("Sairia correndo desesperadamente", 1));
            lstrespostas.Add(new Resposta("Ligaria para o Exército", 5));
            lstrespostas.Add(new Resposta("Tiraria fotos ou filmava", 7));
            lstrespostas.Add(new Resposta("Mataria e penduraria a sua cabeça", 10));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            //------------------------------------------------------------------------------
            lstrespostas = new List<Resposta>();

            pergunta = "Mate sua mente, beba algo diferente:";

            lstrespostas.Add(new Resposta("Suco de ervas do monte kilimanjaro", 5));
            lstrespostas.Add(new Resposta("Pasta de duende carregador", 10));
            lstrespostas.Add(new Resposta("Esta pergunta me confundiu", 1));
            lstrespostas.Add(new Resposta("Todas as alternativas estão corretas", 7));

            lstreturn.Add(new Pergunta(pergunta, lstrespostas));
            //------------------------------------------------------------------------------

            return lstreturn;
        }
    }
}
