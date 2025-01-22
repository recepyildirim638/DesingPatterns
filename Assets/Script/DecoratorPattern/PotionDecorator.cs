using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public abstract class PotionDecorator : IPotion
    {
        protected IPotion potion;
        protected readonly int value;

        public PotionDecorator(int value)
        {
            this.value = value;
        }

        public void Decorate(IPotion potion)
        {
            if(ReferenceEquals(this, potion)) return;

            if(this.potion is PotionDecorator decorator)
            {
                decorator.Decorate(potion);
            }
            else
            {
                this.potion = potion;
            }
        }

        public virtual int UsePotion()
        {
            Debug.Log("Base potion: " +  value);
            return potion?.UsePotion() + value ?? value;
        }
    }
}

