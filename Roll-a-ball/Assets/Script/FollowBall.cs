using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

    [SerializeField]
    GameObject player;

    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = player.transform.position + offset;

        transform.position = movement;
	}
}
