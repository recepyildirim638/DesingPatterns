using System.Diagnostics;

namespace DecoratorPattern
{
    public class SpeedPotion : IPotion
    {
        private readonly int value;

        public SpeedPotion(int value)
        {
            this.value = value;
        }
        public int UsePotion()
        {
           return value;
        }
    }
}

