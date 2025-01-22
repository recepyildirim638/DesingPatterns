using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCommand : ICommand
{
    private CarrierController carrierController;
    public void AddCarrier(CarrierController carrierController)
    {
        this.carrierController = carrierController;
    }

    public void Execute()
    {
        carrierController.Hello();
    }
}
