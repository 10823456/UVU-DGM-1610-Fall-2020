// Anson Price 9/8/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private Vector3 offset = new Vector3(0, 6, -10);
    public GameObject player;
    void Update()
    {
        //set the cam to player object plus preset offset
        transform.position = player.transform.position + offset;
    }
}
