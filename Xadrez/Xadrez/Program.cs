using tabuleiro;
using partida;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PartidaDeXadrez partida = new PartidaDeXadrez();
            Tela.imprimirTabuleiro(partida.Tab);


           


        }
    }
}