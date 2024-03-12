using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forceAmount = 10;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // WASD controller
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * forceAmount);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceAmount);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * forceAmount);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmount);
        }
    }
}
