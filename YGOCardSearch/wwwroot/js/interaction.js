import { renderDeckCards } from './rendering.js'; // Import the rendering function
import {
    addCardToMainDeck,
    addCardToExtraDeck,
    addCardToSideDeck,
    removeCardFromMainDeck,
    removeCardFromExtraDeck,
    removeCardFromSideDeck,
    getMainDeck,
    getExtraDeck,
    getSideDeck
} from './deck.js'; // Import the deck methods


// Function to handle adding a card to a deck
function handleAddToDeck(deckType, deck, card) {
    switch (deckType) {
        case 'MainDeck':
            addCardToMainDeck(deck, card);
            break;
        case 'ExtraDeck':
            addCardToExtraDeck(deck, card);
            break;
        case 'SideDeck':
            addCardToSideDeck(deck, card);
            break;
        default:
        // Handle unsupported deck type
    }
    renderDeckCards(getDeck(deck, deckType), `.DeckBuilder_Container_${deckType}`);
    console.log(`Added "${card.name} id: ${card.id}" to the ${deckType}.`);
}
function getDeck(deck, deckType) {
    switch (deckType) {
        case 'MainDeck':
            return deck.mainDeck;
            break;
        case 'ExtraDeck':
            return deck.extraDeck;
            break;
        case 'SideDeck':
            return deck.sideDeck;
            break;
        default:
    }
}
// Function to handle removing a card from a deck
function handleRemoveFromDeck(deckType, cardId) {
    switch (deckType) {
        case 'MainDeck':
            removeCardFromMainDeck(cardId);
            break;
        case 'ExtraDeck':
            removeCardFromExtraDeck(cardId);
            break;
        case 'SideDeck':
            removeCardFromSideDeck(cardId);
            break;
        default:
        // Handle unsupported deck type
    }
    renderDeckCards(getDeck(deckType), `.DeckBuilder_Container_${deckType}`);
    console.log(`Removed card with ID ${cardId} from the ${deckType}.`);
}
// Function to update the displayed decks
function updateDisplayedDecks() {
    renderDeckCards(decks.mainDeck, '.DeckBuilder_Container_MainDeck');
    renderDeckCards(decks.extraDeck, '.DeckBuilder_Container_ExtraDeck');
    renderDeckCards(decks.sideDeck, '.DeckBuilder_Container_SideDeck');
}
// Example usage




export { handleAddToDeck, handleRemoveFromDeck, updateDisplayedDecks };
