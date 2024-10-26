using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscode : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicmanager logic;
    public bool birdisalive = true;
    
    void Start()
    {
         logic = GameObject.FindWithTag("logic").GetComponent<logicmanager>();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)== true && birdisalive==true)
        {
            myrigidbody.velocity =Vector2.up * flapstrength;
        }
        if(transform.position.y>17 || transform.position.y <-17)
        {
            offscreen();
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        logic.gameover();
        birdisalive=false;
   }
   private void offscreen()
   {
    logic.gameover();
    birdisalive=false;
   }

}
