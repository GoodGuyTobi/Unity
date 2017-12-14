using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    [SerializeField]
    float speed;

    Rigidbody rb;
    float moveZ, moveX;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        moveZ = Input.GetAxisRaw("Vertical");
        moveZ *= Time.deltaTime;

        moveX = Input.GetAxisRaw("Horizontal");
        moveX *= Time.deltaTime;
        
	}

    private void FixedUpdate()
    {
        //transform.Translate(new Vector3(moveX * speed, 0, moveZ * speed));
        Vector3 moveTo = new Vector3(rb.position.x + moveX, 0, rb.position.z + moveZ);
        rb.MovePosition(moveTo);
    }
}
