using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    [SerializeField]
    float speed = 10f;

    [SerializeField]
    Text scoreText;

    int score = 0;

    float moveX, moveZ;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
	}

    //Fixed update is called once every other frame
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX * speed, 0, moveZ * speed);

        rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            score++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
