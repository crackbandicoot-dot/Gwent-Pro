using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class WeatherCard : RowModifierCard
{
    public WeatherCard(string name, Factions faction, string imagePath, List<AttackRows> attackRows, float penalizationQuotient) :
    base(name, faction, imagePath, attackRows, penalizationQuotient,Effects.WeatherEffect)
    {

    }
}

