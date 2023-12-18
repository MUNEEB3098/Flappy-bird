using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*using static UnityEngine.RuleTile.TilingRuleOutput;*/

public class Bird : MonoBehaviour
{
    AudioSource audi;
   
    public static Transform position;
    private Rigidbody2D rb;
    private float speed = 5f;
    private float jumpForce = 4f;
    public static bool collided;
    bool start=true,speeda=false,gravity=false;
    private void Awake()
    {
        collided= true;
        position = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        audi=GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        if (Input.GetButtonDown("Jump")&&start)
        {
            rb.gravityScale = 1.5f;
            start = false;
            collided = false;
        }
        
        if (!collided)
            Jump();
        if (transform.position.x < 258f)
        {

            if (!collided)
                Movement();
            
        }
        else
        {
            transform.position =new Vector3(5.7999f, transform.position.y, transform.position.z);
             // Stop the bird's movement after reaching the desired position
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            audi.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void Movement()
    {
       
        
            rb.velocity = new Vector2(speed, rb.velocity.y);
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            collided = true;
            rb.gravityScale = 0f;
            rb.velocity = Vector2.zero;
        }
        
        if (collision.gameObject.CompareTag("Slow"))
        {
            
            speed -= 1.5f;

            increaseSpeed();
        }
        if (collision.gameObject.CompareTag("Gravity"))
        {
            Debug.Log("worked");
            rb.gravityScale += 1f;
            increaseGravity();
        }
    }
    IEnumerator increaseSpeed() 
    {
        yield return new WaitForSeconds(8);
        speed += 1.5f;
    }
    IEnumerator increaseGravity()
    {
        yield return new WaitForSeconds(5);
        rb.gravityScale -= 1f;
    }

}
