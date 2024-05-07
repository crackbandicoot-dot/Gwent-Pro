using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.ComponentModel.Design;
using UnityEngine;
using Unity.VisualScripting;

public class Player
{
#nullable enable
    #region Properties
   
    private static int s_PlayerIDSeed = 0;
    private bool _isPlaying = false;
    private bool leaderEffectUsed =false;
    private bool winsInTieCase = false;
    private float numberOfVictories = 0;
    public float NumberOfVictories { get => numberOfVictories; }
    public float PowerPoints { get => _board.GetPlayerScore(PlayerID); }
    public Board _board;
    public bool IsPlaying { get => _isPlaying; }
    public LeaderCard Leader { get => _playerDeck.Leader; }
    public bool LeaderEffectUsed { get => leaderEffectUsed; }
    public bool WinsInTieCase { get => winsInTieCase; }
    public string PlayerName { get; }
    public int PlayerID { get; }

    private readonly Deck _playerDeck;

    private Hand _playerHand = new Hand(new List<Card>());
    public Hand PlayerHand { get => _playerHand; }

    public bool Passed = false;
    #endregion

    #region Methods

    #region Constructors
    public Player(Deck playerDeck, Board board)
    {
        PlayerID = s_PlayerIDSeed;
        s_PlayerIDSeed++;
        PlayerName = "Player" + (PlayerID + 1);
        _playerDeck = playerDeck;
        _board = board;
    }
    public Player(Deck playerDeck, Board board, string playerName)
    {
        PlayerID = s_PlayerIDSeed;
        s_PlayerIDSeed++;
        PlayerName = playerName;
        _playerDeck = playerDeck;
        _board = board;
    }
    #endregion

    #region Player Methods
    public void AddToHand(Card card)
    {
        if (_playerHand.NumberOfCards < 10) _playerHand.AddCard(card);
    }
    public void Fetch(int amountOfCardsToFetch)
    {
        int amountOfFectechedCards = 0;
        while (amountOfFectechedCards < amountOfCardsToFetch)
        {
            if (_playerDeck.NumberOfCards > 0)
            {
                Card? fetchedCard = _playerDeck.FetchCard();
                if (_playerHand.NumberOfCards < 10)
                {
                    _playerHand.AddCard(fetchedCard);
                }
                amountOfFectechedCards++;
            }
            else
            {
                break;
            }
        }
    }
    public void PlayCard(Card card, AttackRows row = AttackRows.M)
    {
        UnityEngine.Debug.Log("Jugador poniendo carta");
        if (card is UnityCard unity)
        {
            if (unity is DecoyCard decoy) PlayCard(decoy, row);
            else PlayCard(unity, row);
        }
        else if (card is BoostCard boostCard)
        {
            PlayCard(boostCard, row);
        }
        else if (card is WeatherCard weatherCard)
        {
            PlayCard(weatherCard, row);
        }
        else if (card is ClearingCard clearingCard)
        {
            PlayCard(clearingCard);
        }
        UnityEngine.Debug.Log(_board.GetScoreInRow(PlayerID, row));
    }
    private void PlayCard(UnityCard unityCard, AttackRows row)
    {
        _board.PlaceCard(unityCard, PlayerID, row);
        _playerHand.RemoveCard(unityCard);
        ActivateEffect(unityCard, row);
    }
    private void PlayCard(DecoyCard decoyCard, AttackRows row)
    {
        //Effect.DecoyEffect(this, row, col);
        _board.PlaceCard(decoyCard, PlayerID, row);
        _playerHand.RemoveCard(decoyCard);
    }
    private void PlayCard(BoostCard boostCard, AttackRows row)
    {
        _board.PlaceCard(boostCard, PlayerID, row);
        Effect.BoostEffect(_board, PlayerID, row, boostCard.PowerQuotient);
        _playerHand.RemoveCard(boostCard);
    }
    private void PlayCard(WeatherCard weatherCard, AttackRows row)
    {
        _board.PlaceCard(weatherCard, row);
        Effect.WeatherEffect(_board, row, weatherCard.PowerQuotient);
        _playerHand.RemoveCard(weatherCard);
    }
    private void PlayCard(ClearingCard clearingCard)
    {
        _playerHand.RemoveCard(clearingCard);
        foreach (AttackRows row in clearingCard.AttackRows)
        {
            Effect.ClearWeatherEffect(_board, row);
        }

    }
    public void RemoveUnityCard(int playerID, AttackRows row, int col)
    => _board.RemoveUnityCard(playerID, row, col);
    public void RemoveWeatherCard(AttackRows row)
    => _board.RemoveWeatherCard(row);
    public void RemoveBoostCard(int playerID, AttackRows row)
    => _board.RemoveBoostCard(playerID, row);
    public void Pass() => Passed = true;
    public void BeginRound() {
        Passed = false;
        leaderEffectUsed = false;
        winsInTieCase = false;  
        Fetch(2);
    }
    public void UseLeaderAbility()
    {
        if (!LeaderEffectUsed)
        {
            ActivateEffect(_playerDeck.Leader);
            leaderEffectUsed = true;
        }
    }
    public void AllowWinInTieCase()
    {
        winsInTieCase = true;
    }
    public void HandleVictory() => numberOfVictories++;
    public void BeginTurn() => _isPlaying= true ;
    public void EndTurn() => _isPlaying= false;
    private void ActivateEffect(UnityCard unityCard,AttackRows row)
    {
        Effects effect = unityCard.Effect;
        switch(effect)
        {
            case Effects.SetPointsToAverage:
                Effect.SetPointsToAverage(_board);
                break;
            case Effects.RemovePowerfulCard:
                Effect.RemovePowerfulCard(_board);
                break;
            case Effects.RemoveWeakCard:
                Effect.RemoveWeakCard(this, _board);
                break;
            case Effects.FetchOneCard:
                Effect.FetchOneCard(this);
                break;
            case Effects.MultiplyByN:
                Effect.MultiplyByN(unityCard, _board);
                break;
            case Effects.ClearRowWithMinimumNumberOfUnities:
                Effect.ClearRowWithMinimumNumberOfUnities(_board);
                break;
            case Effects.WeatherEffect:
                Effect.WeatherEffect(_board, row, 0.8f);
                break;
            case Effects.BoostEffect:
                Effect.BoostEffect(_board, PlayerID, row, 1.5f);
                break;
            default:
                break;
        }
    }
    private void ActivateEffect(LeaderCard leaderCard)
    {
        Effects effect = leaderCard.Effect;
        switch (effect)
        {
            case Effects.FetchOneCard:
                Effect.FetchOneCard(this);
                break;
            case Effects.WinInTieCase:
                Effect.WinInTieCase(this);
                break;
            default:
                break;
        }
    }
    #endregion
    #region Static Methods
    public static int GetOpponentID(int playerID) => (playerID + 1) %2;

    #endregion
    #endregion
}

