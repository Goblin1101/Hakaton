using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateActivator : MonoBehaviour
{
    [SerializeField]
    Gate gate;

    private bool _activated = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gate.GateOpen();
        activationSwitch();
    }

    private void activationSwitch()
    {
        if (_activated) _activated = false;
        else _activated = true;
    }
}
