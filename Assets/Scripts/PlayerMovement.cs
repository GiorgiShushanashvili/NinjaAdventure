using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed =5f;
    private float direction;
    private Rigidbody2D rb;
    //jump
    public float jumpForce;
    public bool isGround;
    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask grounLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(direction*moveSpeed,rb.velocity.y);

        isGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, grounLayer);

        if (Input.GetButtonDown("Jump")&&isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
