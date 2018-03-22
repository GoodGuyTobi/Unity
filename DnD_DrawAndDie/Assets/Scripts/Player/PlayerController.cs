using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 10f;
    float movement;

    [SerializeField]
    float jumpForce = 100f;
    bool grounded = true;
    bool doubleJump = true;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal");
	}

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);
    }

}
