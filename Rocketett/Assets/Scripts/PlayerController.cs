using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
        float thrustForce = 5f;
    [SerializeField]
    float torque = 2f;

    public GameObject rocketParticleSystem;

    bool alive = true;

    [SerializeField]
    GameObject missile;

    Rigidbody rb;
    GameManager gm;

    private void Start()
    {
        //Hämtar Rigidbodyn
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {
        if (alive)
        {
            float rot = Input.GetAxis("Horizontal") * -1;
            //Rör spelaren framåt!
            Movement();

            //Rotera Spelaren
            transform.Rotate(new Vector3(0, 0, rot * torque));

            //Skjuter
            fire();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            //DÖ
            gm.GameOver();
            alive = false;
        }
    }

    void fire()
    {
        if(Input.GetAxis("Fire1") > 0.5)
        {
            GameObject firedMissile = Instantiate(missile,transform.position,transform.rotation);
        }
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Använda sig utav rigidbodyn för att röra sig framåt
            rb.AddRelativeForce(new Vector3(0, thrustForce * 10));

            //Sätt igång raketerna
            rocketParticleSystem.SetActive(true);
        }
        else
        {
            //Stäng av de igen
            rocketParticleSystem.SetActive(false);
        }
    }

}
