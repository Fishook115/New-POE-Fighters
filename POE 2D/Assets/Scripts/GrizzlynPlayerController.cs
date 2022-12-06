using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynPlayerController : MonoBehaviour
{
    float dirX, moveSpeed;

    Animator anim;

    private Rigidbody2D rb;

    // Initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //player can move and punch
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);


        if (dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("Punch");
        }

        //Check for collisions
        int count = rb.Cast(direction, movementFilter, castCollisions, moveSpeed * Time.fixedDeltaTime + collisionOffset);

        
        
    }

}
