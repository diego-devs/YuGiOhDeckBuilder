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

        [HttpPost("duplicate")]
        public IActionResult DuplicateDeck([FromBody] string deckName)
        {
            try
            {
                // Construct original and new file paths
                string originalDeckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], deckName + ".ydk");
                string newDeckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], "Copy_" + deckName + ".ydk");

                // Check if the new file path already exists
                if (File.Exists(newDeckFilePath))
                {
                    // Handle the case where the new file path already exists
                    Console.WriteLine($"Error duplicating deck {deckName}.ydk: Destination file already exists");
                    return new ConflictResult(); // Return HTTP 409 Conflict status code
                }

                // Copy the deck file to the new location
                File.Copy(originalDeckFilePath, newDeckFilePath);

                Console.WriteLine($"Deck {deckName}.ydk duplicated to {newDeckFilePath} successfully");

                return new OkResult(); // Return HTTP 200 OK status code
            }
            catch (Exception e)
            {
                // Handle other exceptions
                Console.WriteLine($"Error duplicating deck {deckName}.ydk: {e.Message}");
                return new BadRequestResult(); // Return HTTP 400 Bad Request status code
            }
        }


        [HttpPost("rename")]
        public IActionResult RenameDeck([FromBody] RenameDeckRequest request)
        {
            try
            {
                string oldDeckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], request.OldDeckName + ".ydk");
                string newDeckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], request.NewDeckName + ".ydk");

                File.Move(oldDeckFilePath, newDeckFilePath);

                Console.WriteLine($"Deck {request.OldDeckName}.ydk renamed to {request.NewDeckName}.ydk successfully");

                return new OkResult();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error renaming deck {request.OldDeckName}.ydk: {e.Message}");
                return new BadRequestResult();
            }
        }

        [HttpPost("delete")]
        public IActionResult DeleteDeck([FromBody] string deckName)
        {
            try
            {
                string deckFilePath = Path.Combine(_configuration["Paths:DecksFolderPath"], deckName + ".ydk");

                File.Delete(deckFilePath);

                Console.WriteLine($"Deck {deckName}.ydk deleted successfully");

                return new OkResult();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error deleting deck {deckName}.ydk: {e.Message}");
                return new BadRequestResult();
            }
        }
    }




}
