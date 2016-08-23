using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratona
{
    public class Jogador
    {
        public int pontuacao = 0;
        public int pontuacaoMarc = 0;
        public IList<int> Cartas { get; set; }

        public Jogador()
        {
            Cartas = new List<int>();
        }

        public void AdicionarCarta(int carta)
        {
            Cartas.Add(carta);
        }

        public void PrimeiraCarta()
        {
            var jogadorPrincipal = Cartas[0];
            pontuacao += jogadorPrincipal;
            pontuacaoMarc = jogadorPrincipal;
            Cartas.Remove(0);
        }

        public void UltimaCarta()
        {
            int countCarta = Cartas.Count - 1;
            var jogadorPrincipal = Cartas[countCarta];
            pontuacao += jogadorPrincipal;
            pontuacaoMarc = jogadorPrincipal;
            Cartas.Remove(countCarta);
        }

        public virtual int Jogar(IList<int> listaCartasDisponiveis, int regra)
        {
            int cartaSelecionada;
            if (regra.Equals(1))
            {
                cartaSelecionada = RegraDosQuatro(listaCartasDisponiveis);
            }
            else
            {
                cartaSelecionada = RegraPrimeiroUltimo(listaCartasDisponiveis);
            }
            
            AdicionarCarta(cartaSelecionada);
            return cartaSelecionada;
        }

        private int RegraPrimeiroUltimo(IList<int> listaCartasDisponiveis)
        {
            int primeiraCarta = listaCartasDisponiveis[0];
            int ultimaCarta = listaCartasDisponiveis[listaCartasDisponiveis.Count() - 1];
                       
            return primeiraCarta > ultimaCarta ? primeiraCarta : ultimaCarta;
        }

        private int RegraDosQuatro(IList<int> listaCartasDisponiveis)
        {
            int primeiraCarta = listaCartasDisponiveis[0];
            int ultimaCarta = listaCartasDisponiveis[listaCartasDisponiveis.Count() - 1];
            int segundaCarta = 0;
            int penultimaCarta = 0;

            if (listaCartasDisponiveis.Count > 2)
            {
                segundaCarta = listaCartasDisponiveis[1];
                penultimaCarta = listaCartasDisponiveis[listaCartasDisponiveis.Count() - 2];
            }

            IList<int> cartas = new List<int>();
            cartas.Add(primeiraCarta);
            cartas.Add(segundaCarta);
            cartas.Add(penultimaCarta);
            cartas.Add(ultimaCarta);

            int maior = listaCartasDisponiveis.Max();
            int cartaSelecionada = 0;

            if (maior.Equals(primeiraCarta))
            {
                cartaSelecionada = primeiraCarta;
            }
            else if (maior.Equals(segundaCarta))
            {
                if(segundaCarta.Equals(penultimaCarta))
                {
                    cartaSelecionada = primeiraCarta > ultimaCarta ? primeiraCarta : ultimaCarta;
                }
                else
                {
                    cartaSelecionada = ultimaCarta;
                }                
            }
            else if (maior.Equals(penultimaCarta))
            {
                if (segundaCarta.Equals(penultimaCarta))
                {
                    cartaSelecionada = primeiraCarta > ultimaCarta ? primeiraCarta : ultimaCarta;
                }
                else
                {
                    cartaSelecionada = primeiraCarta;
                }
            }
            else
            {
                cartaSelecionada = ultimaCarta;
            }

            return cartaSelecionada;
        }

        private int RegraDosQuatroMenor(IList<int> listaCartasDisponiveis)
        {
            int primeiraCarta = listaCartasDisponiveis[0];
            int ultimaCarta = listaCartasDisponiveis[listaCartasDisponiveis.Count() - 1];
            int segundaCarta = 0;
            int penultimaCarta = 0;

            if (listaCartasDisponiveis.Count > 2)
            {
                segundaCarta = listaCartasDisponiveis[1];
                penultimaCarta = listaCartasDisponiveis[listaCartasDisponiveis.Count() - 2];
            }

            IList<int> cartas = new List<int>();
            cartas.Add(primeiraCarta);
            cartas.Add(segundaCarta);
            cartas.Add(penultimaCarta);
            cartas.Add(ultimaCarta);

            int menor = listaCartasDisponiveis.Min();
            int cartaSelecionada = 0;

            if (menor.Equals(primeiraCarta))
            {
                cartaSelecionada = primeiraCarta;
            }
            else if (menor.Equals(segundaCarta))
            {
                if (segundaCarta.Equals(penultimaCarta))
                {
                    cartaSelecionada = primeiraCarta > ultimaCarta ? primeiraCarta : ultimaCarta;
                }
                else
                {
                    cartaSelecionada = ultimaCarta;
                }
            }
            else if (menor.Equals(penultimaCarta))
            {
                if (segundaCarta.Equals(penultimaCarta))
                {
                    cartaSelecionada = primeiraCarta > ultimaCarta ? primeiraCarta : ultimaCarta;
                }
                else
                {
                    cartaSelecionada = primeiraCarta;
                }
            }
            else
            {
                cartaSelecionada = ultimaCarta;
            }

            return cartaSelecionada;
        }
    }
}