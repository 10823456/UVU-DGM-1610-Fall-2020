using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroryOutOfBounds : MonoBehaviour
{

    public float topBounds = 30f;
    public float lowerBounds = -15f;
    // Hey, if they out of bounds, destroy!
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!"); //If out of lower bounds, game over!
            Destroy(gameObject);
        }
    }
}
