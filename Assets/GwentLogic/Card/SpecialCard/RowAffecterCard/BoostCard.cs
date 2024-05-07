using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BoostCard : RowModifierCard
{
    public BoostCard(string name, Factions faction, string imagePath, List<AttackRows> attackRows, float boostQuotient) : base(name, faction, imagePath,attackRows,boostQuotient,Effects.BoostEffect)
    {

    }
    
}

