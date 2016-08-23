using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratona
{
    class Program
    {
        //static JogadorPrincipal JogadorPrincipal = new JogadorPrincipal(new List<int>
        //{
        //    0
        //    , -3
        //    , 5
        //    , 10
        //});
        //static JogadorSecundario JogadorSecundario = new JogadorSecundario(new List<int>
        //{
        //    0
        //    , -3
        //    , 5
        //    , 10
        //});

        

        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            JogadorPrincipal jogadorPrincipal = new JogadorPrincipal();
            JogadorSecundario jogadorSecundario = new JogadorSecundario();

            string respostaSair = string.Empty;
            
            int totalPontos1 = 0;
            int totalPontos2 = 0;

            do
            {
                jogadorPrincipal = new JogadorPrincipal();
                jogadorSecundario = new JogadorSecundario();

                jogo.InicializarJogo();

                int cartaSelecionada;
                int somatorioP1PrimeiroUltimo = 0;
                int somatorioP1RegraQuatro = 0;
                do
                {
                    cartaSelecionada = jogadorPrincipal.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), 0);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);
                    somatorioP1PrimeiroUltimo += cartaSelecionada;

                    cartaSelecionada = jogadorSecundario.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), 0);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);

                } while (jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).Count() > 0);

                jogo.ListaCartasSelecionadas = new List<int>();
                jogadorPrincipal = new JogadorPrincipal();
                jogadorSecundario = new JogadorSecundario();

                do
                {
                    cartaSelecionada = jogadorPrincipal.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), 1);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);
                    somatorioP1RegraQuatro += cartaSelecionada;

                    cartaSelecionada = jogadorSecundario.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), 1);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);

                } while (jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).Count() > 0);

                jogo.ListaCartasSelecionadas = new List<int>();
                jogadorPrincipal = new JogadorPrincipal();
                jogadorSecundario = new JogadorSecundario();

                int melhorRegra = somatorioP1PrimeiroUltimo > somatorioP1RegraQuatro ? 0 : 1;
                do
                {
                    cartaSelecionada = jogadorPrincipal.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), melhorRegra);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);

                    cartaSelecionada = jogadorSecundario.Jogar(jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).ToList(), melhorRegra);
                    jogo.AdicionarCartaSelecionada(cartaSelecionada);

                } while (jogo.ListaCartas.Except(jogo.ListaCartasSelecionadas).Count() > 0);

                totalPontos1 = 0;
                totalPontos2 = 0;

                Console.WriteLine("Jogador Principal pegou as seguintes cartas:");
                foreach (var carta in jogadorPrincipal.Cartas)
                {
                    Console.Write("{0} ", carta);
                    totalPontos1 += carta;
                }
                Console.WriteLine("Totalizando {0} pontos.", totalPontos1);
                Console.WriteLine(string.Empty);
                                
                Console.WriteLine("Jogador Secundario pegou as seguintes cartas:");
                foreach (var carta in jogadorSecundario.Cartas)
                {
                    Console.Write("{0} ", carta);
                    totalPontos2 += carta;
                }
                Console.WriteLine("Totalizando {0} pontos.", totalPontos2);
                Console.WriteLine(string.Empty);

                Console.WriteLine("Regra {0}", melhorRegra);


                //Console.WriteLine("Deseja Encerrar? (S/N)");
                //respostaSair = Console.ReadLine();
            } while (totalPontos1 > totalPontos2);//!respostaSair.ToLower().Equals("s"));
            //int count = 4;

            //for (int i = 0; i < count; i++)
            //{
            //    if (escolhaCartas.Next(1, 3).Equals(1))
            //    {
            //        JogadorPrincipal.PrimeiraCarta();
            //    }
            //    else
            //    {
            //        JogadorPrincipal.UltimaCarta();
            //    }

            //    if (escolhaCartas.Next(1, 3).Equals(1))
            //    {
            //        JogadorSecundario.PrimeiraCarta();
            //    }
            //    else
            //    {
            //        JogadorSecundario.UltimaCarta();
            //    }

            //    if (JogadorPrincipal.pontuacaoMarc > JogadorSecundario.pontuacaoMarc)
            //    {
            //        Console.WriteLine("Principal: " + JogadorPrincipal.pontuacaoMarc);
            //        Console.WriteLine("Principal Pontos: " + JogadorPrincipal.pontuacao);
            //        // pontuacaoSecundario = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Secundario: " + JogadorSecundario.pontuacaoMarc);
            //        Console.WriteLine("Secundario Pontos: " + JogadorSecundario.pontuacaoMarc);
            //        //pontuacaoPrincipal = 0;
            //    }

            //}
            Console.ReadLine();
        }
    }
}
