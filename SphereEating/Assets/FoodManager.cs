using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {

    public GameObject food; // spawn food prefab to be spawned    
    // An array of the spawn points this enemy can spawn from.
    // Use this for initialization
    public int maxX=50;
    public int maxZ=50;
    public int minZ =-50;
    public int minX =-50;
    public int numberOfFoods;

    void Start () {
        Debug.Log("Spawning food");
        for (int i = 0; i < numberOfFoods; i++)
        {     
            Instantiate(food, new Vector3(Random.Range(minX, maxX), 0.75f,  Random.Range(minZ, maxZ)), Quaternion.identity);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        // Instantiate(food, 1, 1, 1);
        // Find a random index between zero and one less than the number of spawn points.
       
    }
}
