using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonaAvanade
{
    class Program
    {
        static JogadorPrincipal JogadorPrincipal = new JogadorPrincipal(new List<int>
        {
            0
            , -3
            , 5
            , 10
        });
        static JogadorSecundario JogadorSecundario = new JogadorSecundario(new List<int>
        {
            0
            , -3
            , 5
            , 10
        });
        static void Main(string[] args)
        {
            int count = 4;
            Random escolhaCartas = new Random();
            for (int i = 0; i < count; i++)
            {
                if (escolhaCartas.Next(1, 3).Equals(1))
                {
                    JogadorPrincipal.PrimeiraCarta();
                }
                else
                {
                    JogadorPrincipal.UltimaCarta();
                }

                if (escolhaCartas.Next(1, 3).Equals(1))
                {
                    JogadorSecundario.PrimeiraCarta();
                }
                else
                {
                    JogadorSecundario.UltimaCarta();
                }

                if (JogadorPrincipal.pontuacaoMarc > JogadorSecundario.pontuacaoMarc)
                {
                    Console.WriteLine("Principal: " + JogadorPrincipal.pontuacaoMarc);
                    Console.WriteLine("Principal Pontos: " + JogadorPrincipal.pontuacao);
                    // pontuacaoSecundario = 0;
                }
                else
                {
                    Console.WriteLine("Secundario: " + JogadorSecundario.pontuacaoMarc);
                    Console.WriteLine("Secundario Pontos: " + JogadorSecundario.pontuacaoMarc);
                    //pontuacaoPrincipal = 0;
                }

            }
            Console.ReadLine();
        }
    }
}
