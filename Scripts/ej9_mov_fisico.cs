using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej9_mov_fisico : MonoBehaviour
{   
    public float speed = 50f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float move_step = speed * Time.fixedDeltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * move_step);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * move_step);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * move_step);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * move_step);
        }
    }
}
