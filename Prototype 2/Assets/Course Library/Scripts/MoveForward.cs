using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
 
    public float speed = 10f;
    void Update() //Move forward at constant rate
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
