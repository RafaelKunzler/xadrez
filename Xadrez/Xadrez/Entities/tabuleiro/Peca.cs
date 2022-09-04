﻿using tabuleiro;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }

        
        void incrementarMovimento()
        {
            QteMovimentos++;
        }

        void decrementarMovimento()
        {
            QteMovimentos--;
        }

        public abstract override string ToString();
       
        
        
            
        
    }
}
