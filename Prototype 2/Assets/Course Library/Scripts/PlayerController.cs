﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10f;
    private float horizontalInput;


    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        if (transform.position.x < -18)
        {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 18)
        {
            transform.position = new Vector3(18, transform.position.y, transform.position.z);
        }

    }
}
