/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class SimpleMovement : MonoBehaviour {

	public float Speed;
    private Animator anim;
	private Vector2 direction;
	private Rigidbody2D rigidbody;
    bool isMoving = false;

	public void Start() {
        anim = GetComponent<Animator>();
		rigidbody = GetComponent<Rigidbody2D>();
	}

    public void Update() {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));               
    }

    public void FixedUpdate() {

        isMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) 
        {
            isMoving = true;
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) 
        {
            isMoving = true;
        }

        rigidbody.velocity = new Vector3(direction.x, direction.y, 0.0f) * Speed;
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", isMoving);
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {
    Animator anim;
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 4;

    //check to see if player is moving or not
    private bool playerMoving;
    //player's last move
    private Vector2 lastMove;


    void Start() {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    }
    //movement
    void FixedUpdate() {

        playerMoving = false;
        if (horizontal != 0 && vertical != 0) {
            body.velocity = new Vector3((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        else {
            body.velocity = new Vector3(horizontal * runSpeed, vertical * runSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }
        //player animator references
        anim.SetFloat("xInput", horizontal);
        anim.SetFloat("yInput", vertical);
        anim.SetBool("isMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

}
