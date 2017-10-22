using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMass : MonoBehaviour {


    public Rigidbody rb;
	// Use this for initialization
	void Start () {

        float diameter = transform.lossyScale.x;
        Debug.Log("Diameter " + diameter);


        float radius = diameter / 2;
        Debug.Log("Radius " + radius);


        float volume = 4 / 3 * Mathf.PI * Mathf.Pow(radius, 3);
        Debug.Log("Volume " +volume);
        rb.mass = volume;

}       
	

}
