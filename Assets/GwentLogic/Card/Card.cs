using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card
{
    public string Name { get;}
    public Factions Faction {get;}
    public string ImagePath {get;}
    public Effects Effect { get;}   
    public Card(string name,Factions faction,string imagePath,Effects effect=Effects.None)
    {
        Name = name;
        Faction = faction;
        ImagePath = imagePath;
        Effect = effect;
    }
    public virtual bool EqualsByProperties(Card otherCard)
        => this.Name == otherCard.Name && this.Faction==otherCard.Faction && this.ImagePath==ImagePath && this.Effect==Effect;
    
}