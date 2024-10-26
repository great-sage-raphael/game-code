using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class middlepipescript : MonoBehaviour
{
    public logicmanager logic;
     public birdscode birdc;
    
    void Start()
    {
       logic = GameObject.FindWithTag("logic").GetComponent<logicmanager>();
       birdc =GameObject.FindWithTag("bird").GetComponent<birdscode>();
    }

   private void OnTriggerEnter2D(Collider2D collision) 
   {
      if(birdc.birdisalive)
      {
         if(collision.gameObject.layer==3)
         {
            logic.addpoints(1);
         }
            
      }
    
   }
}
