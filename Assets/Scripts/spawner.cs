using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaculo;

    private float timeBtwSpawn;
    public float startime;
    public float decreasetime;
    public float minTime=0.65f;


    private void Update(){

        if(timeBtwSpawn <= 0){

            int rand=Random.Range(0,obstaculo.Length);
            Instantiate(obstaculo[rand],transform.position,Quaternion.identity);
            timeBtwSpawn=startime;

            if(startime>minTime){

                  startime-=decreasetime;


            }
          


        }else{

            timeBtwSpawn -= Time.deltaTime;
        }



    }
}
