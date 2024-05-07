using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Deck
{
    public int NumberOfCards { get => _deckCards.Count; }

    private readonly List<Card> _deckCards;
    private LeaderCard _leaderCard;
    public LeaderCard Leader { get => _leaderCard; }
    public Deck(string name, List<Card> deckCards,LeaderCard leader)
    {
        _deckCards = deckCards;
        _leaderCard = leader;

    }
    public Card FetchCard()
    {
        Card fectchedCard = _deckCards[^1];
        _deckCards.RemoveAt(_deckCards.Count-1);
        return fectchedCard;
       
    }
    public void Shuffle()
    {
        System.Random random = new(); 
        for (int i = NumberOfCards-1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (_deckCards[j], _deckCards[i]) = (_deckCards[i], _deckCards[j]);
        }
    }

}

