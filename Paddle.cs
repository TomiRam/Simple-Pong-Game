using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public KeyCode up;
    public KeyCode down;
    Rigidbody2D rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            rigidBody.velocity = new Vector2(0f, 7f);
        }
        else if (Input.GetKey(down))
        {
            rigidBody.velocity = new Vector2(0f, -7f);
        }
        else
        {
            rigidBody.velocity = new Vector2(0f, 0f);
        }
    }
}
	
	
