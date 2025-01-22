using UnityEngine;

namespace DecoratorPattern
{
    public class HealtDecarator : PotionDecorator
    {
        public HealtDecarator(int value) : base(value){}

        public override int UsePotion()
        {
            Debug.Log("Healt potion: " + value);
            HealtOthers();
            return potion?.UsePotion() ?? 0;
        }

        public void HealtOthers()
        {

        }
    }
}

