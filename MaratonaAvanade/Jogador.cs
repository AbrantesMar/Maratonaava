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
        public List<int> Cartas = new List<int>();

        public Jogador(List<int> cartas)
        {
            Cartas = new List<int>
            {
                0
                , -3
                , 5
                , 10
            };
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
    }
}
