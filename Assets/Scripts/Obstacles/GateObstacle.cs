using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateObstacle : Gate
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public override void GateOpen()
    {
        base.GateOpen();
        rb.simulated = false;
    }

    public override void GateClose()
    {
        base.GateClose();
        rb.simulated = true;
    }
}
