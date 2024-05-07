using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

public class ClearingCard : SpecialCard
{
    public ClearingCard(string name, Factions faction, string imagePath, List<AttackRows> attackRows) : base(name, faction, imagePath, attackRows, Effects.ClearWeather)
    {
    }
}
