using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private void OnDestroy()
    {
        NotesEvents.OnNotePickedUp?.Invoke();
    }
}
