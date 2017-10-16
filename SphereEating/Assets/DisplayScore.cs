using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour {

    // Update is called once per frame

    public Text currentScore;
    public PlayerCollision playerMass;
	void Update () {
        currentScore.text = "MASS " + playerMass.playerMass.ToString("0");
	}
}
