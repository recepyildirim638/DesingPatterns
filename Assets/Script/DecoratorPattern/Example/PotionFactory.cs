using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern.Example
{
    public static class PotionFactory
    {
        public static IPotion CreatePotion(PotionTypeSO potionType)
        {
            return potionType.type switch
            {
                PotionType.Speed => new SpeedPotion(potionType.value),
                PotionType.Healt => new HealtDecarator(potionType.value),
                PotionType.Damage => new DamageDecarator(potionType.value),
                _ => new SpeedPotion(potionType.value)
            };
        } 
    }
}

