using UnityEngine;

public class CarryObject : MonoBehaviour
{
    bool isAddCommand = false;
    private void OnMouseDown()
    {
        if (CommandGameManager.ins.activeCarrier == null)
            return;

        if (isAddCommand == false)
        {
            CarryCommand carryCommand = new CarryCommand(this.gameObject);
            CommandGameManager.ins.activeCarrier.AddCommand(carryCommand);
            isAddCommand = true;
        }
    }
}
