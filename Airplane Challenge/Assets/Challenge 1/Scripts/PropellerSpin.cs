using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float speed = 180f;
    public GameObject propeller;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
