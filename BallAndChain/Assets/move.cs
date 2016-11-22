using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.name == "Sphere")
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(transform.forward * 50f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(transform.right * -50f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(transform.forward * -50f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * 50f);
            }
        }

        if (transform.name == "Sphere (1)")
        {
            if (Input.GetKey(KeyCode.I))
            {
                rb.AddForce(transform.forward * 50f);
            }
            if (Input.GetKey(KeyCode.J))
            {
                rb.AddForce(transform.right * -50f);
            }
            if (Input.GetKey(KeyCode.K))
            {
                rb.AddForce(transform.forward * -50f);
            }
            if (Input.GetKey(KeyCode.L))
            {
                rb.AddForce(transform.right * 50f);
            }
        }
    }
}
