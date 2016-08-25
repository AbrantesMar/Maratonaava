using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratona
{
    public class Jogo
    {
        public IList<int> ListaCartas { get; set; }
        public IList<int> ListaCartasSelecionadas { get; set; }

        public Jogo()
        {
            ListaCartas = new List<int>();
            ListaCartasSelecionadas = new List<int>();
        }

        public bool ValidarQuantidadeCartas(int qtdCartas, ref string mensagem)
        {
            bool retorno = true;
            if (qtdCartas.Equals(0) ||
                (!qtdCartas.Equals(0) && (qtdCartas % 2) != 0))
            {
                mensagem = "Quantidade de cartas informada está incorreta!";
                retorno = false;
            }

            return retorno;
        }

        public void InicializarJogo()
        {
            ListaCartas = new List<int>();
            ListaCartasSelecionadas = new List<int>();
            int qtdCartas = 6;
            string qtdCartasInformada = string.Empty;
            string mensagem = string.Empty;

            bool valido = false;
            //do
            //{
            //    Console.Write("Favor informar a quantidade de cartas que o jogo terá: ");
            //    qtdCartasInformada = Console.ReadLine();

            //    if (int.TryParse(qtdCartasInformada, out qtdCartas))
            //    {
            //        valido = ValidarQuantidadeCartas(qtdCartas, ref mensagem);
            //        if (!valido)
            //        {
            //            Console.WriteLine(mensagem);
            //        }
            //    }

            //} while (valido.Equals(false));

            Random escolhaCartas = new Random();
            StringBuilder cartasDistribuicao = new StringBuilder();
            int carta;
            for (int i = 0; i < qtdCartas; i++)
            {
                do
                {
                    carta = escolhaCartas.Next(qtdCartas);
                    if (ListaCartas.Contains(carta))
                    {
                        carta = -1;
                    }

                } while (carta.Equals(-1));

                ListaCartas.Add(carta);
                cartasDistribuicao.Append(string.Concat(carta, " "));
            }

            //ListaCartas.Add(1);
            //cartasDistribuicao.Append(string.Concat(1, " "));
            //ListaCartas.Add(0);
            //cartasDistribuicao.Append(string.Concat(0, " "));
            //ListaCartas.Add(2);
            //cartasDistribuicao.Append(string.Concat(2, " "));
            //ListaCartas.Add(3);
            //cartasDistribuicao.Append(string.Concat(3, " "));
            //ListaCartas.Add(4);
            //cartasDistribuicao.Append(string.Concat(4, " "));
            //ListaCartas.Add(5);
            //cartasDistribuicao.Append(string.Concat(5, " "));
            //ListaCartas.Add(7);
            //cartasDistribuicao.Append(string.Concat(7, " "));
            //ListaCartas.Add(9);
            //cartasDistribuicao.Append(string.Concat(9, " "));
            //ListaCartas.Add(8);
            //cartasDistribuicao.Append(string.Concat(8, " "));
            //ListaCartas.Add(2);
            //cartasDistribuicao.Append(string.Concat(2, " "));

            Console.WriteLine("As cartas do jogo são: {0}", cartasDistribuicao.ToString());
        }

        public void AdicionarCartaSelecionada(int carta)
        {
            ListaCartasSelecionadas.Add(carta);
        }
    }
}