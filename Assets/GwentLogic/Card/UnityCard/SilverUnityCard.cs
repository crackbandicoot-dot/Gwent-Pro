using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class SilverUnityCard : UnityCard
{
    public override bool AffectedByEffects { get => true; }
    public SilverUnityCard(string name, Factions faction, string imagePath, int powerPoints, List<AttackRows> attackRows,Effects effect) : base(name, faction, imagePath, powerPoints, attackRows,effect)
    {
    } 
}


