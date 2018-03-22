using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour {

    [SerializeField]
    Transform player;
    [SerializeField]
    float camSpeed;

    Vector3 offset;

    private void Start()
    {
        offset = player.position - transform.position;
    }

    private void Update()
    {
        //Följ efter spelaren, i X oxh Y-led
        Vector3 desiredPosition = new Vector3(player.position.x,player.position.y) - offset;

        transform.position = Vector3.Lerp(transform.position,desiredPosition,camSpeed * Time.deltaTime);
    }
}
