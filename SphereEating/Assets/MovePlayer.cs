using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 100;
    public float sidewaysForce = 100;
    public float speed;
    Vector3 targetPosition;
    // Use this for initialization
    void Start () {
        speed = speed * Time.deltaTime;
        targetPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
             
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed);
            }
        }


        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
