using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroryOutOfBounds : MonoBehaviour
{

    public float topBounds = 30f;
    public float lowerBounds = -15f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
