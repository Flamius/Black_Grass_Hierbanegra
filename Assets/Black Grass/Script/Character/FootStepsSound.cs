using UnityEngine;

public class FootStepsSound : MonoBehaviour
{
    public AudioSource footStepSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footStepSound.enabled = true;
        }
        else footStepSound.enabled = false;
    }
}
