using NotTidduss.Core.Enums;
using NotTidduss.Core.Extensions;
using System;
using System.Collections.Generic;

namespace NotTidduss.Core.Helpers
{
    public static class PlayingCardHelper
    {
        /// <summary>
        /// Gets PlayingCard list for each item in the Enum
        /// </summary>
        /// <returns></returns>
        public static List<PlayingCard> GeneratePlayingCards()
        {
            return EnumHelpers.EnumValuesToList<PlayingCard>();
        }
        /// <summary>
        /// Shuffles deck using random insertion from one array into another.
        /// </summary>
        /// <param name="playingCards"></param>
        /// <returns></returns>
        public static List<PlayingCard> ShufflePlayingCards(List<PlayingCard> playingCards)
        {
            return playingCards.ShuffleItems();
        }

        /// <summary>
        /// Draw PlayingCard from dop of the deck
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public static PlayingCard DrawPlayingCard(List<PlayingCard> deck)
        {
            PlayingCard playingCard = deck[0];
            deck.RemoveAt(0);

            return playingCard;
        }
        /// <summary>
        /// Returns [numberOfPlayers] cards from the top of the deck
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="numberOfPlayers"></param>
        /// <returns></returns>
        public static List<PlayingCard> DrawPlayingCards(List<PlayingCard> deck, int numberToDraw)
        {
            if (deck.Count < numberToDraw) throw new Exception("Trying to draw too many cards!");

            var playingCards = new List<PlayingCard>();
            for (int i = 0; i < numberToDraw; i++)
            {
                playingCards.Add(DrawPlayingCard(deck));
            }

            return playingCards;
        }
        /// <summary>
        /// Returns [numberOfPlayers] cards from the top of the deck
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="numberOfPlayers"></param>
        /// <returns></returns>
        public static List<PlayingCard> DrawPlayingCardForEachPlayer(List<PlayingCard> deck, int numberOfPlayers)
        {
            return DrawPlayingCards(deck, numberOfPlayers);
        }
        /// <summary>
        /// Draw [numberToDraw] cards for [numberOfPlayers] players 
        /// in alternating fashion and return a pile for each player
        /// with [numberToDraw] cards.
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="numberOfPlayers"></param>
        /// <param name="numberToDraw"></param>
        /// <returns></returns>
        public static Dictionary<int, List<PlayingCard>> DrawPlayingCardsForEachPlayer(List<PlayingCard> deck, int numberOfPlayers, int numberToDraw)
        {
            var cardPiles = new Dictionary<int, List<PlayingCard>>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                cardPiles[i] = new List<PlayingCard>();
            }

            for (int cardCount = 0; cardCount < numberToDraw; cardCount++)
            {
                for (int player = 0; player < numberOfPlayers; player++)
                {
                    cardPiles[player].Add(DrawPlayingCard(deck));
                }
            }

            return cardPiles;
        }
    }
}
