using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Protagonist_Controller : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed;
    private Rigidbody2D rb;

    private float x;
    private float y;

    private Vector2 input;
    private bool moving;
    private void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        GetInput();
        Animate();
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;
    }
    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        input = new Vector2(x, y);
        input.Normalize();
    }
    private void Animate()
    {
        if (input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        if (moving)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
        }
        anim.SetBool("Moving", moving);
    }

}
