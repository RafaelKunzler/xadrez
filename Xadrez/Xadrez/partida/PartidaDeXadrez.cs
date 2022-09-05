using tabuleiro;

namespace partida
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; set; }
        public int Turno { get; set; }
        public Cor JogadorAtual { get; set; }
        public bool Terminada { get; set; }
        public HashSet<Peca> Pecas { get; set; }
        public HashSet<Peca> Capturadas { get; set; }
        public bool Xeque { get; set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            Xeque = false;
            colocarPecas();
        }

        public void colocarNovaPeca(Peca p, Posicao pos)
        {
            Tab.Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
            
           
        }

        public void colocarPecas()
        {
            colocarNovaPeca(new Torre(Cor.Branco, Tab), Posicao.ToPosicao("e3"));
            colocarNovaPeca(new Torre(Cor.Branco, Tab), Posicao.ToPosicao("e5"));
            colocarNovaPeca(new Rei(Cor.Branco, Tab), Posicao.ToPosicao("h2"));



        }

    }
}
