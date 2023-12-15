using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Sprite Close_state;
    [SerializeField]
    Sprite Open_state;
    SpriteRenderer _renderer;

    private bool _state = false;


    private void Start()
    {_renderer = gameObject.GetComponent<SpriteRenderer>();
        
        _renderer.sprite = Close_state;
    }

    public virtual void GateOpen()
    {
        _renderer.sprite = Open_state;
        _state = true;

    }
    public virtual void GateClose()
    {
        _renderer.sprite = Close_state;
        _state = false;
    }
    public bool GetGateState()
    {
        return _state;
    }
}
