﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {

    
    public float PullRadius;
    public float GravitationalPull;
    public float MinRadius;
    public float DistanceMultiplier;
    public PlayerCollision playerMass;
    public LayerMask LayersToPull;


    void FixedUpdate() {
        Collider[] colliders = Physics.OverlapSphere(transform.position, PullRadius, LayersToPull);
        PullRadius = playerMass.playerMass;
        foreach (var collider in colliders) {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            if (rb == null) continue;

            Vector3 direction = transform.position - collider.transform.position;

            // adding the mass to the radius
            if (direction.magnitude < MinRadius) continue;

            float distance = direction.sqrMagnitude * DistanceMultiplier + 1;
     
            rb.AddForce(direction.normalized * (GravitationalPull / distance) * rb.mass * Time.deltaTime);
        }
    }
    




}
