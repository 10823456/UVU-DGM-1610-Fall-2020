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
    private float turnSpeed = 70f;
    private float xInput; //Forward and back
    private float yInput; //side to side


    void Update()
    {
        yInput = Input.GetAxis("Horizontal"); //I assume it uses some list of keys like left and right arrow, along with A and D
        xInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * xInput); // Player won't move without input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * yInput); //Tank turning!

       
    }
}
