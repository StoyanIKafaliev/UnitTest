using NUnit.Framework;
using SantaseGameEngine;
using SantaseGameEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaseGameEngine_NUnitTest.DeckTests
{
    [TestFixture]
    public class DeckClassTest
    {
        [Test]
        public void ShouldCreateNewDeck()
        {
            // Arange
            IDeck deck = new Deck();

            // Act & Assert
            Assert.IsInstanceOf<IDeck>(deck);
        }

        [Test]
        public void ShouldChangeTrumCard()
        {
            // Arange
            IDeck deck = new Deck();
            Card card_1 = new Card(CardSuit.Heart, CardType.Queen);

            // Act 
            deck.ChangeTrumpCard(card_1);

            // Assert
            Assert.AreSame(card_1, deck.TrumpCard);
        }

        [TestCase(CardSuit.Heart, CardType.Queen)]
        [TestCase(CardSuit.Diamond, CardType.Jack)]
        [TestCase(CardSuit.Spade, CardType.Queen)]
        public void ShouldChangeTrumCard(CardSuit suit, CardType type)
        {
            // Arange
            IDeck deck = new Deck();
            Card card_1 = new Card(suit, type);

            // Act 
            deck.ChangeTrumpCard(card_1);

            // Assert
            Assert.AreSame(card_1, deck.TrumpCard);
        }
    }
}
