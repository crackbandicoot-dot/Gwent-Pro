using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class RowModifierCard : Card
{
    public List<AttackRows> AttackRows { get; } = new List<AttackRows>();
    public float PowerQuotient { get; }
    public RowModifierCard(string name, Factions faction, string imagePath, List<AttackRows> attackRows, float powerQuotient, Effects effect) : base(name, faction, imagePath, effect)
    {
        PowerQuotient = powerQuotient;
        AttackRows = attackRows;
    }
}

