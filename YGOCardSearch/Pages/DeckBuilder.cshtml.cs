using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using YGOCardSearch.Data.Models;
using YGOCardSearch.DataProviders;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using YGOCardSearch.Data;
using Microsoft.EntityFrameworkCore;

namespace YGOCardSearch.Pages
{
    public class DeckBuilder : PageModel
    {
        // Esto tambien debera cambiar por db:
        public List<Deck> LoadedDecks;
        // Deck a visualizar
        public Deck Deck { get; set; }
        // Repo de todas las cartas (migrar a db) - sera obsoleto 
        public List<Card> AllCards { get; set; } 
        // Database
        public readonly YgoContext Context;

        // Dependency injection 
        public DeckBuilder(YgoContext db)
        {
            // Good place to initialize data

            // Load the Database from the Context class
            this.Context = db;
            
            this.AllCards = new List<Card>(Context.Cards);
            
            
            //foreach (var card in AllCards)
            //{
             //   card.CardImages = new List<CardImages>(AllImages.Where(i => i.CardImageId == card.KonamiCardId));
             //   card.CardSets = new List<CardSet>(AllSets.Where(s => s.CardId== card.CardId));
             //   card.CardPrices = new List<CardPrices>(AllPrices.Where(p => p.CardId == card.CardId));
            //}

            // LoadAllDecks();
            LoadedDecks = new List<Deck>();
            Deck = new Deck();
            string path = @"C:\Users\PC Gamer\source\repos\YuGiOhTCG\YGOCardSearch\Data\Decks\deck1.ydk";
            LoadedDecks.Add(LoadDeck(path));
            Deck = LoadedDecks.First(); // make selection with dropdrown menu 

            // PrepareDeck
            foreach (var card in Deck.MainDeck)
            {
                card.CardImages = new List<CardImages>(Context.CardImages.Where(i => i.CardImageId == card.KonamiCardId));
                card.CardSets = new List<CardSet>(Context.CardSets.Where(s => s.CardId == card.CardId));
                card.CardPrices = new List<CardPrices>(Context.CardPrices.Where(p => p.CardId == card.CardId));
            }
        }
        
        void UpdateImagesProperty(List<Card> cardList, CardImages propValue)
        {
            if (cardList.Count == 0)
                return;

            // change the property of the current object
            cardList[0].GetType().GetProperty("CardImages").SetValue(cardList[0], propValue);

            // call the function again with the tail of the list
            UpdateImagesProperty(cardList.Skip(1).ToList(), propValue);
        }
        public async Task<IActionResult> OnGet()
        {
            
            return Page();

        }
        /// <summary>
        /// Revisa si el deck tiene ning�n error, lo corrige y regresa el deck.
        /// </summary>
        /// <param name="deckList"></param>
        public static List<string> CleanDeck(List<string> deckList) 
        {
            var returnedDeckList = new List<string>(deckList);

            foreach (var cardId in deckList)
            {
                var cardChars = cardId.ToCharArray();
                bool allClean = cardChars.All(c => char.IsDigit(c));
                if (allClean) 
                {
                    continue;
                }
                else 
                {
                    var onlyDigitsIds = cardChars.Where(c => char.IsDigit(c));
                    var stringId = new string(onlyDigitsIds.ToArray());
                    
                    returnedDeckList.Add(stringId);
                    returnedDeckList.Remove(cardId);
                    continue;
                }
               
            }
            
            return returnedDeckList;
        } 
        ///<summary>
        ///<para>Regresa un DeckModel tomando un archivo .ydk como par�metro</para>
        ///<para>archivos .ydk</para>
        ///</summary>
        public Deck LoadDeck(string path)
        {
            foreach (string file in Directory.EnumerateFiles(@"C:\Users\PC Gamer\source\repos\YuGiOhTCG\YGOCardSearch\Data\Decks", " *.ydk"))
            {
                string contents = System.IO.File.ReadAllText(file);
            }
            // Asegurarnos que la extensi�n sea .ydk (?)...
            string[] ydkDeck = System.IO.File.ReadAllLines(path); // De donde sea se encuentren los decks? 
            var deckIds = new List<string>(ydkDeck);

            int mainIndex = deckIds.FindIndex(c => c.Contains("#main"));
            int extraIndex = deckIds.FindIndex(r => r.Contains("#extra"));
            int sideIndex = deckIds.FindIndex(c => c.Contains("!side"));
            
            var mainDeckResult = deckIds.Skip(mainIndex + 1).Take(extraIndex - (mainIndex + 1)).ToList();
            var extraDeckResult = deckIds.Skip(extraIndex + 1).Take(sideIndex - (extraIndex + 1)).ToList();
            var sideDeckResult = deckIds.Skip(sideIndex + 1).Take(sideIndex - (extraIndex + 1)).ToList();

            // Limpiar las listas de IDS, algunos decks podr�an tener errores como: "112345f" 
            var cleanedMain = CleanDeck(mainDeckResult);
            var cleanedExtra = CleanDeck(extraDeckResult);
            var cleanedSide = CleanDeck(sideDeckResult);
            
            // Obtener todas las cartas de las listas de Ids a listas de cartas
            var mainDeck = new List<Card>(getCardList(cleanedMain));
            var extraDeck = new List<Card>(getCardList(cleanedExtra));
            var sideDeck = new List<Card>(getCardList(cleanedSide));

            // Finalmente crear el deck retornado
            var newDeck = new Deck();
            newDeck.MainDeck = mainDeck;
            newDeck.ExtraDeck = extraDeck;
            newDeck.SideDeck = sideDeck;
            newDeck.DeckName = newDeck.MainDeck.First().Name.ToString().ToLower(); 
            return newDeck;

        }
        
        /// <summary>
        /// Regresa lista de CardModel a partir de una lista de CardIdKonami, buscando en YgoDB.
        /// </summary>
        /// <param name="cardList"></param>
        /// <returns></returns>
        public List<Card> getCardList(List<string> cardList) 
        {
                var cards = new List<Card>();
                foreach (var cardId in cardList)
                {
                    if (AllCards.Exists(c => c.KonamiCardId == Convert.ToInt32(cardId)))
                    {
                        Card card = AllCards.Single(c => c.KonamiCardId == Convert.ToInt32(cardId));
                        cards.Add(card);
                    }

                }
 
            return cards;
        }
        public Deck PrepareDeck(Deck deck)
        {
            return null; 
        }
    }
}
