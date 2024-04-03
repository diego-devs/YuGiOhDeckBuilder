﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using YGODeckBuilder.Data;
using YGODeckBuilder.Data.Models;

namespace YGODeckBuilder.API
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class DeckController
    {
        private readonly IConfiguration _configuration;
        private readonly DeckUtility _deckUtility;

        public DeckController(IConfiguration configuration)
        {
            this._configuration = configuration;

        }

        [HttpPost("save")]
        public IActionResult SaveDeck([FromBody] Deck deck)
        {
            // Process the received deck data here,
            // such as saving to the database or export it as YDK file

            Console.WriteLine($"Saving deck {deck.DeckName}.ydk");

            if (deck.MainDeck != null)
            {
                try
                {
                    // Save the deck as .YDK file
                    ExportDeck(deck);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new BadRequestResult();
                }
                return new OkResult(); // Return a success response
            }
            return null;
        }

        // get current deck from the JS code and save it as a .ydk file 
        public void ExportDeck(Deck deck)
        {
            // Save the deck to a .ydk file
            string deckName = deck.DeckName; // get the deck name from file name
            string deckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], deckName + ".ydk");
            using (StreamWriter writer = new StreamWriter(deckFilePath))
            {
                // Write the main deck
                writer.WriteLine("#main");
                foreach (var card in deck.MainDeck)
                {
                    writer.WriteLine(card.KonamiCardId);
                }
                // Write the extra deck
                writer.WriteLine("#extra");
                foreach (var card in deck.ExtraDeck)
                {
                    writer.WriteLine(card.KonamiCardId);
                }
                // Write the side deck
                writer.WriteLine("!side");
                foreach (var card in deck.SideDeck)
                {
                    writer.WriteLine(card.KonamiCardId);
                }
            }
            Console.WriteLine($"Deck {deckName}.ydk exported to {deckFilePath} successfully");
        }




    }


   

}