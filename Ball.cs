using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        Direction();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Direction()
    {
        int direction;
        direction = Random.Range(0, 2);
        if (direction == 0)
        {
            rigidBody.velocity = new Vector2(5f, -3f);
        }
        else
        {
            rigidBody.velocity = new Vector2(-5f, 3f);
        }
    }
}
