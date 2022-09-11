using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 posicion;
    public float Yin=3;
    public float speed=80;
    public float Max=3;
    public float Min=-3;


    public float vidas=3;

 
    private void Update()

    {


        if(vidas<=0){

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        transform.position=Vector2.MoveTowards(transform.position,posicion,speed*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<Max){

            posicion=new Vector2(transform.position.x,transform.position.y+Yin);
           
        }else   if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y>Min){

            posicion=new Vector2(transform.position.x,transform.position.y-Yin);
           
         
    }
}
}