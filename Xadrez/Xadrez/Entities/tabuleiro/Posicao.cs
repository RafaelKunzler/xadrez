using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Posicao
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }

        public static Posicao ToPosicao(String pos)
        {
            string auxColuna = pos.Substring(0, 1);
            string auxLinha = pos.Substring(1);
            int coluna = char.ToUpper(auxColuna[0]) - 65;

            int linha = 8 - int.Parse(auxLinha);
            
            Posicao p = new Posicao(linha, coluna);
            return p;

        }
    }
}
