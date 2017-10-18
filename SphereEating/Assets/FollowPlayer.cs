using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public PlayerCollision playerMass;
    protected float fSpeed = 1;
    protected float fDistance = 1;
    public Vector3 zoomOut;
    public GameObject Tower;
    // Update is called once per frame
    void Update() {



        // so this zoomout is the final destination, we want to lerp to this
        zoomOut = new Vector3(0, playerMass.playerMass / 2, 0) + offset + player.position;
        transform.position = Vector3.Lerp(player.position, zoomOut, 0.9f);


        // transform.position = player.position + offset +new Vector3(0, playerMass.playerMass/2, 0);
    }
          
}
