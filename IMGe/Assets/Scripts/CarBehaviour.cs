using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarBehaviour : MonoBehaviour {

    Rigidbody rb;
    public float acceleration;
    public float maxSpeed;
   // public int basicZ;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.Log("rb vel in Update" + rb.velocity);
        
        
    }

    public void Accelerate()
    {
        // if (Mathf.Abs(rb.velocity.z) < maxSpeed)
        // {
        //     rb.velocity = rb.velocity + new Vector3(0, 0, acceleration * Time.deltaTime);
        // }
        // rb.velocity = rb.velocity + new Vector3(0, 0, acceleration * Time.deltaTime);
        //transform.Translate(Vector3.back * Time.deltaTime * acceleration
        //     );
        rb.velocity = new Vector3(0, 0, -acceleration);
        Debug.Log("rb vel:" + rb.velocity);
    }

    public void SlowDown()
    {
        rb.velocity = Vector3.zero;
    }
}
