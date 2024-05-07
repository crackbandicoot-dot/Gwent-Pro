using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class DecoyCard : UnityCard
{
    public DecoyCard(string name, Factions faction, string imagePath, List<AttackRows> attackRows) : base(name, faction, imagePath, 0, attackRows, Effects.DecoyEffect)
    {

    }
    public override bool AffectedByEffects => false;
}


