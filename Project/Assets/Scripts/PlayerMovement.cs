using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 4;
    public float JumpForce = 10f; 
    
    private Rigidbody2D rb2d;
    
    private Animator anim;
    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb2d.velocity.y) < 0.001f)
        {
            rb2d.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (Mathf.Abs(rb2d.velocity.y) > 0.001f)
        {
            anim.SetBool("isJumping", true);
        } 
        else
        {
            anim.SetBool("isJumping", false);
        }
        
    
    }
}
