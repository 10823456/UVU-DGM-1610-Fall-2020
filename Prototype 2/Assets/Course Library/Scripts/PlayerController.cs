using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
      public float speed = 10f;
    private float horizontalInput;
    public GameObject projectilePrefab;

    void Update()// Player Movment 
    {
        
        horizontalInput = Input.GetAxis("Horizontal"); //Left+Right keys move Player
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        if (transform.position.x < -20)//Keeping the player inbounds
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyUp(KeyCode.Space))//Firing the projectile! 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
