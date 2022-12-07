using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynPlayerController : MonoBehaviour
{
    //move character
    float dirX, moveSpeed;

    Animator anim;

<<<<<<< Updated upstream
=======
    //player one and player two rigid body
>>>>>>> Stashed changes
    private Rigidbody2D rb;

    // Initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
<<<<<<< Updated upstream
        rb = GetComponent<Rigidbody2D>();
=======

        //player one and player 2 rigid body
        rb = GetComponent<Rigidbody2D>();

>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        //player can move and punch
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
=======
        if (name == "Fighter_Grizzlyn")
        {
            dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
>>>>>>> Stashed changes

            transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

<<<<<<< Updated upstream

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

        
        
=======
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
        }

>>>>>>> Stashed changes
    }

}
