using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
