using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        Vector3 movementVector = player.transform.position - transform.position;
        rb.AddForce(movementVector, ForceMode.VelocityChange);

        //rozwi�zanie tymczasowe, finalnie despawn po opuszczeniu ekranu
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
