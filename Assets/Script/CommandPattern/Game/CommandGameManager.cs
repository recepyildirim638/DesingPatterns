using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandGameManager : MonoBehaviour
{
    public static CommandGameManager ins;
    private void Awake()
    {
        ins = this;
        activeCarrier = null;
    }

    public Carrier activeCarrier;
}
