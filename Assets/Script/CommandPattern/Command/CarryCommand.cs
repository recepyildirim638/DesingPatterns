using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryCommand : ICommand
{
    private GameObject carryObject;
    private CarrierController carrier;
    public CarryCommand(GameObject carryObject)
    {
        this.carryObject = carryObject;
    }

    public void AddCarrier(CarrierController carrier)
    {
       this.carrier = carrier;
    }

    public void Execute()
    {
        
    }
}
