using UnityEngine;

namespace DecoratorPattern.Example
{
    public class PotionManager : MonoBehaviour
    {
        public static PotionManager ins;

        private void Awake()
        {
            ins = this;
        }

        public BuffPotionController SelectedBuffPotion;

        public void Decorate(BuffPotionController clickedBuffPotion)
        {
            if (SelectedBuffPotion == clickedBuffPotion) return;

            if(SelectedBuffPotion.Potion is PotionDecorator decorator)
            {
                Debug.Log("Decorating Points...");
                decorator.Decorate(clickedBuffPotion.Potion);
                clickedBuffPotion.Potion = decorator;
            }
            else
            {
                Debug.Log("can NOT decorate");
            }

        }
    }

}

