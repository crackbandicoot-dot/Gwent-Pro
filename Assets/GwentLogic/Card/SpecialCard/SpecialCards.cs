using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class SpecialCard : Card
{
    public List<AttackRows> AttackRows { get; } = new List<AttackRows>();
    public SpecialCard(string name, Factions faction, string imagePath,List<AttackRows> attackRows,Effects effect) : base(name,faction,imagePath,effect)
    {
       AttackRows = attackRows;
    }
}

