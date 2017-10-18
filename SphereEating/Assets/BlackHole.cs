using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (transform.position.z > 50) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -49);
        }
        if (transform.position.z < -50)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 49);
        }

        if (transform.position.x > 50)
        {
            transform.position = new Vector3(-49, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -50)
        {
            transform.position = new Vector3(49, transform.position.y, transform.position.z);
        }


    }
}
