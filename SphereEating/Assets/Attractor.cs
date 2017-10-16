﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour {

    public Rigidbody rb;
    const float G = 667.4f;

    public static List<Attractor> Attractors;

    void FixedUpdate() { 
        foreach (Attractor attractor in Attractors) {
            if (attractor != this)
            {
                Attract(attractor);
            }
        }

    }

    void OnEnable() {

        if (Attractors == null) 
            Attractors = new List<Attractor>();
        Attractors.Add(this);
    }

    void OnDisabled() {
        Attractors.Remove(this);
    }

    void Attract(Attractor objToAttract) {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position -rbToAttract.position;

        // the length of the direction vector
        float distance = direction.magnitude;

        float forceMagnitude = G *(rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}