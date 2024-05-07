using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CardContainer
{
    private int ammountOfPlayers=2;
    public  List<LeaderCard> goodsLeaders = new List<LeaderCard>(); 
    public  List<List<Card>> goodsDecks = new List<List<Card>>();
    public CardContainer()
    {

        for (int i = 0; i < ammountOfPlayers; i++)
        {
            //Goods Decks
            goodsDecks.Add(new List<Card>());
            goodsLeaders.Add(new LeaderCard("Dipper", Factions.Goods, "", Effects.FetchOneCard));
            goodsDecks[i].Add(new GoldUnityCard("Stan", Factions.Goods, "", 7, new List<AttackRows>() { AttackRows.M, AttackRows.S }, Effects.FetchOneCard));
            goodsDecks[i].Add(new SilverUnityCard("Soos", Factions.Goods, "", 6, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.ClearRowWithMinimumNumberOfUnities));
            goodsDecks[i].Add(new SilverUnityCard("Soos", Factions.Goods, "", 6, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.ClearRowWithMinimumNumberOfUnities));
            goodsDecks[i].Add(new SilverUnityCard("Soos", Factions.Goods, "", 6, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.ClearRowWithMinimumNumberOfUnities));
            goodsDecks[i].Add(new SilverUnityCard("Wendy", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M }, Effects.MultiplyByN));
            goodsDecks[i].Add(new SilverUnityCard("Wendy", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M }, Effects.MultiplyByN));
            goodsDecks[i].Add(new SilverUnityCard("Wendy", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M }, Effects.MultiplyByN));
            goodsDecks[i].Add(new GoldUnityCard("Pacifica", Factions.Goods, "", 7, new List<AttackRows>() { AttackRows.R }, Effects.BoostEffect));
            goodsDecks[i].Add(new GoldUnityCard("Mabel", Factions.Goods, "", 6, new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }, Effects.RemovePowerfulCard));
            goodsDecks[i].Add(new DecoyCard("Pato", Factions.Goods, "", new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }));
            goodsDecks[i].Add(new DecoyCard("Pato", Factions.Goods, "", new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }));
            goodsDecks[i].Add(new BoostCard("PittCola", Factions.Neutral, "", new List<AttackRows>() { AttackRows.R }, 1.5f));
            goodsDecks[i].Add(new BoostCard("PittCola", Factions.Neutral, "", new List<AttackRows>() { AttackRows.R }, 1.5f));
            goodsDecks[i].Add(new BoostCard("CirculoDeUnidad", Factions.Goods, "", new List<AttackRows>() { AttackRows.M }, 1.8f));
            goodsDecks[i].Add(new BoostCard("CirculoDeUnidad", Factions.Goods, "", new List<AttackRows>() { AttackRows.M }, 1.8f));
            goodsDecks[i].Add(new BoostCard("LinternaDeCrecimiento", Factions.Neutral, "", new List<AttackRows>() { AttackRows.S }, 1.9f));
            goodsDecks[i].Add(new BoostCard("LinternaDeCrecimiento", Factions.Neutral, "", new List<AttackRows>() { AttackRows.S }, 1.9f));
            goodsDecks[i].Add(new WeatherCard("Niebla", Factions.Neutral, "", new List<AttackRows>() { AttackRows.R }, 0.8f));
            goodsDecks[i].Add(new WeatherCard("Diluvio", Factions.Neutral, "", new List<AttackRows>() { AttackRows.M }, 0.6f));
            goodsDecks[i].Add(new WeatherCard("Tormenta", Factions.Neutral, "", new List<AttackRows>() { AttackRows.S }, 0.7f));
            goodsDecks[i].Add(new ClearingCard("SolResplandeciente", Factions.Neutral, "", new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }));
            goodsDecks[i].Add(new ClearingCard("SolResplandeciente", Factions.Neutral, "", new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }));
            goodsDecks[i].Add(new GoldUnityCard("Gideon", Factions.Goods, "", 6, new List<AttackRows>() { AttackRows.M, AttackRows.R, AttackRows.S }, Effects.RemoveWeakCard));
            goodsDecks[i].Add(new SilverUnityCard("Robby", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.WeatherEffect));
            goodsDecks[i].Add(new SilverUnityCard("Robby", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.WeatherEffect));
            goodsDecks[i].Add(new SilverUnityCard("Robby", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.M, AttackRows.R }, Effects.WeatherEffect));
            goodsDecks[i].Add(new SilverUnityCard("BlendinBlandin", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.R, AttackRows.S }, Effects.SetPointsToAverage));
            goodsDecks[i].Add(new SilverUnityCard("BlendinBlandin", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.R, AttackRows.S }, Effects.SetPointsToAverage));
            goodsDecks[i].Add(new SilverUnityCard("BlendinBlandin", Factions.Goods, "", 4, new List<AttackRows>() { AttackRows.R, AttackRows.S }, Effects.SetPointsToAverage));
        }
    }
}


