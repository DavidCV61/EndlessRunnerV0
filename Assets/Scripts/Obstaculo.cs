using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    public float speed1;
    public int damage=1;
   

	void Update () {
        transform.Translate(Vector2.left * speed1 * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
       other.GetComponent<Player>().vidas--;
            
            Destroy(gameObject);

           
    }
}