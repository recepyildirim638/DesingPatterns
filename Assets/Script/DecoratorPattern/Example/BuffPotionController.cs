using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DecoratorPattern.Example
{
    public class BuffPotionController : MonoBehaviour
    {
        [SerializeField] private PotionTypeSO potionType;

        Button button;
        public IPotion Potion { get; set; }

        private void Awake()
        {
            Potion = PotionFactory.CreatePotion(potionType);
            button = GetComponent<Button>();
            button.onClick.AddListener(() => OnButtonClick());
        }

        private void OnButtonClick()
        {
            if(PotionManager.ins.SelectedBuffPotion == null)
            {
                PotionManager.ins.SelectedBuffPotion = this;
                Debug.Log("Select potion: " + PotionManager.ins.SelectedBuffPotion);
            }
            else
            {
                PotionManager.ins.Decorate(this);
                PotionManager.ins.SelectedBuffPotion = null;
            }
        }
    }
}

