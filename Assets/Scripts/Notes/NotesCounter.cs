using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCounter : MonoBehaviour
{
    private int _notesCount = 0;

    private void Awake()
    {
        NotesEvents.OnNotePickedUp += IncreaseCounter;
        NotesEvents.OnNotePickedUp += DisplayCount;
    }

    private void IncreaseCounter()
    {
        _notesCount++;
    }
    ///TODO: Реализовать в виде GUI
    private void DisplayCount()
    {
        Debug.Log(_notesCount);
    }
}
