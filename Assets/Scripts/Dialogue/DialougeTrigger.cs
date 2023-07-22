using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public Dialoge dialogue;
    public GameObject Balloon;
    
    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogeManager>().StartDialogue(dialogue);
        }
    }
}
