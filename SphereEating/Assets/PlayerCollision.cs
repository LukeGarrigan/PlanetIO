using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
    public MovePlayer movement;
    // An array of the spawn points this enemy can spawn from.
    // Use this for initialization
    public int maxX = 50;
    public int maxZ = 50;
    public int minZ = -50;
    public int minX = -50;
    public GameObject food;
    public Vector3 offset;
    public float playerMass = 1;
    public Rigidbody foodMass;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "FoodTag")
        {
           
            Destroy(collisionInfo.collider.gameObject);
            Debug.Log(foodMass.mass);
            playerMass += foodMass.mass;
            transform.localScale += new Vector3(foodMass.mass/10, foodMass.mass/10, foodMass.mass/10);
            Instantiate(food, new Vector3(Random.Range(minX, maxX), 0.75f, Random.Range(minZ, maxZ)), Quaternion.identity);
        }

    


    }
}
