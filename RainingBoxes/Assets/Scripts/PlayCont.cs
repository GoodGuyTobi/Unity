using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCont : MonoBehaviour {

    Rigidbody rb;

    [SerializeField]
    private float baseSpeed = 3.14f;
    [SerializeField]
    private float thrustForce = 3.14f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal") * baseSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * baseSpeed * Time.deltaTime;

        rb.MovePosition(new Vector3(moveX + transform.position.x, transform.position.y, moveZ + transform.position.z));

        if(Input.GetAxis("Jump")>0)
        {
            rb.AddForce(new Vector3(0,thrustForce * 10,0));
        }

	}
}
