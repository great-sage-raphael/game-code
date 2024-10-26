using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spwanrate=2;
    private float Timer =0;
    public float highoffset=10;
    void Start()
    {
        spawner();
    }
    void Update()
    {
      if(Timer < spwanrate){
        Timer += Time.deltaTime;
      }
      else{
        spawner();
        Timer=0;
      }
    }

    void spawner()
    {
        float lowestpoint = transform.position.y - highoffset;
        float highestpoint  =transform.position.y + highoffset ;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0),transform.rotation);
    }

   
}

