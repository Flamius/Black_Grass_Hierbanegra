using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField]
    private DialogueManager dialogues;
    public bool DialogueTriggered;
    public void TriggerDialogue()

    {
        if (!DialogueTriggered)
        { 
        DialogueTriggered = true;
        dialogues.StartDialogue(dialogue);
        }

    }
}
