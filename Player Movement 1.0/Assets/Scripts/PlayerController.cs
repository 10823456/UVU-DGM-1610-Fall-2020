using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    private float speed = 20f;
    private float turnSpeed = 40f;
    private float xInput; //side to side
    private float yInput; //forward and back


    void Update()
    {
        yInput = Input.GetAxis("Horizontal");
        xInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * xInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * yInput);

       
    }
}
