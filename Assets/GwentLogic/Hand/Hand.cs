using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hand
{
    private List<Card> _handCards;
    public List<Card> Cards { get => _handCards; }
    public int NumberOfCards { get => _handCards.Count; }

    public Hand(List<Card> handCards)
    {
        _handCards = handCards;
    }
    public void AddCard(Card card)
    {
     _handCards.Add(card);
    }
    public Card RemoveCard(int cardPosition)
    {
        Card card = _handCards[cardPosition];
        _handCards.RemoveAt(cardPosition);
        return card;
    }
    public Card RemoveCard(Card card)
    {
        _handCards.Remove(card);
        return card;
    }
    public void ShowCards()
    {
        for (int i = 0; i < NumberOfCards; i++)
        {
            Console.WriteLine($"{ i}:{ _handCards[i].Name}");
        }
    }
}
