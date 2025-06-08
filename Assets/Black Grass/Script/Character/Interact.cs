using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            NotifyPlayer();
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        DeNotifyPlayer();
        Debug.Log("Player now not in range");
    }
    public void NotifyPlayer()
    {
        

    }

    public void DeNotifyPlayer()
    {
        
    }
}
