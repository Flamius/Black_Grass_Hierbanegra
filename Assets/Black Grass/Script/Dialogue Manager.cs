using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public Animator animator;
    private Queue<string> sentencesQueue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    sentencesQueue = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {   
        animator.SetBool("Isopen", true);

        nameText.text = dialogue.name;
       

        foreach (string sentence in dialogue.sentences)
        {
            
            sentencesQueue.Enqueue(sentence);     
        }

    DisplayNextSentence();    
    }
    // Update is called once per frame
    public void DisplayNextSentence()
    {
        
        if (sentencesQueue.Count == 0)

        {
            
            EndDialogue();
            return;
        }
        
        string sentence = sentencesQueue.Dequeue();
       
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;

        }
    }
    void EndDialogue()
    {
        animator.SetBool("Isopen", false);

    }
   
}
