﻿using System.Collections.Generic;
using System.Threading.Tasks;
using YGODeckBuilder.Data.Models;

namespace YGODeckBuilder.Interfaces
{
    public interface IDeckUtility
    {
        Task<Deck> LoadDeckAsync(string path);
        List<DeckPreview> LoadDecksPreview();
        void PrepareCardData(Deck deck);
        void PrepareCardDataSearch(List<Card> cards);
        
    }
}
