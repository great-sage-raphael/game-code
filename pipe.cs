using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float movingspeed =5;
    public float deadzone =-46;
    void Start()
    {
        
    }
    void Update()
    {
      transform.position = transform.position +( Vector3.left * movingspeed )*Time.deltaTime;
      if(transform.position.x < deadzone)
      {
        Destroy(gameObject);
        Debug.Log("destroyed");
      }
    }

}
