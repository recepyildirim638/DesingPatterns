using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarrierController))]
public class Carrier : MonoBehaviour
{
    [SerializeField] private int ýd;
    private CommandInvoker commandInvoker = new CommandInvoker();
    private CarrierController carrierController;

    private bool isActive = false;

    private void Awake()
    {
        carrierController = GetComponent<CarrierController>();
    }

    public void AddCommand(ICommand command)
    {
        command.AddCarrier(carrierController);
        commandInvoker.AddCommand(command);
    }

    private void OnMouseDown()
    {
        HelloCommand helloCommand = new HelloCommand();
        CommandGameManager.ins.activeCarrier = this;
        AddCommand(helloCommand);
    }
}
