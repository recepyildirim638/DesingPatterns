using UnityEngine;

namespace DecoratorPattern
{
    public class DamageDecarator : PotionDecorator
    {
        public DamageDecarator(int value) : base(value){}

        public override int UsePotion()
        {
            Debug.Log("Damage potion: " + value);
            DamageOthers();
            return potion?.UsePotion() ?? 0;
        }

        public void DamageOthers()
        {

        }
    }
}

