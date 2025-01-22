using UnityEngine;
using UnityEngine.UI;

namespace DecoratorPattern.Example
{

    public class MainPotionController : MonoBehaviour
    {
        Button button;
        private void Awake()
        {
          
            button = GetComponent<Button>();
            button.onClick.AddListener(() => OnButtonClick());
        }

        private void OnButtonClick()
        {
            if (PotionManager.ins.SelectedBuffPotion != null)
            {
                PotionManager.ins.SelectedBuffPotion.Potion.UsePotion();
                Debug.Log("Select potion: " + PotionManager.ins.SelectedBuffPotion.name);
            }
            else
            {
                Debug.Log("Speed Main Used");
            }
        }
    }

}

