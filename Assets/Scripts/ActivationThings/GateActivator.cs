using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class GateActivator : MonoBehaviour
{
    [SerializeField]
    Gate gate;

    [SerializeField]
    Animation on_state;
    [SerializeField]
    Animation off_state;

    protected bool _activated = false;


    protected void activationSwitch()
    {
        if (_activated) _activated = false;
        else _activated = true;
    }
    public virtual void GateActivate()
    {
        if (_activated) on_state.Play();
        gate.GateOpen();

    }
    public virtual void GateDeactivate()
    {
        if (!_activated) off_state.Play();
        gate.GateClose();

    private void activationSwitch()
    {
        if (_activated) _activated = false;
        else _activated = true;
    }
}
