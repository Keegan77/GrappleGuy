using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    public GrapplingRope gr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        //Debug.Log(rb.velocity.x);
        if (gr.enabled == false)
        {
            if (moveInput == 1)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                if (rb.velocity.x < 0)
                {
                    rb.velocity = new Vector2(0, rb.velocity.y);
                }
            }
            if (moveInput == -1)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                if (rb.velocity.x > 0)
                {
                    rb.velocity = new Vector2(0,rb.velocity.y);
                }
            }
        }
        if (gr.enabled == true)
        {
            if (moveInput == 1)
            {
                transform.Translate(Vector2.right * 5 * Time.deltaTime);
            }
            if (moveInput == -1)
            {
                transform.Translate(Vector2.left *  5 *Time.deltaTime);
            }
            
        }
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            Destroy(gameObject);
        }
    }
}
