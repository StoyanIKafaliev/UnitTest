using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaseGameEngine.Contracts
{
    public interface IDeck
    {
        Card TrumpCard { get; }

        int CardsLeft { get; }

        Card GetNextCard();

        void ChangeTrumpCard(Card newCard);
    }
}
