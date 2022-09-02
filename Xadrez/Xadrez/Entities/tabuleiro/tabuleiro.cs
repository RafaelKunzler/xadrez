using tabuleiro;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Peca[,] Pecas { get; set; }

        public Tabuleiro(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
            Pecas = new Peca[linha, coluna];
        }

        public Tabuleiro(Peca[,] pecas)
        {
            this.Pecas = pecas;
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        
        
        
    }
}
