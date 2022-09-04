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

            int linha = 0;
            switch (auxLinha)
            {
                case "0":
                    linha = 8;
                    break;
                case "1":
                    linha = 7;
                    break;
                case "2":
                    linha = 6;
                    break;
                case "3":
                    linha = 5;
                    break;
                case "4":
                    linha = 4;
                    break;
                case "5":
                    linha = 3;
                    break;
                case "6":
                    linha = 2;
                    break;
                case "7":
                    linha = 1;
                    break;
                case "8":
                    linha = 0;
                    break;
            }



            Posicao p = new Posicao(linha, coluna);
            return p;

        }
    }
}
