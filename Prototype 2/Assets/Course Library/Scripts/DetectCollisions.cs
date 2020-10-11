using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

  void OnTriggerEnter(Collider box)//Two coliders touch, delete! 
    {
        Destroy(gameObject);
        Destroy(box.gameObject);
    }

}
