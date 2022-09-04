using tabuleiro;
using partida;

namespace Xadrez
{
    internal class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            int k = 8;
            for (int i = 0; i < tab.Linha; i++)
            {
                
                Console.Write(k + " ");
                for (int j = 0; j < tab.Coluna; j++)
                {


                    if (tab.Pecas[i, j] == null)
                    {
                        Console.Write("- ");
                    }
                    else 
                    {
                        Console.Write(tab.Pecas[i, j]);
                    }
                    
                }
                Console.WriteLine();
                k--;
            }
            Console.WriteLine("  a b c d e f g h");

        }


    }
}
