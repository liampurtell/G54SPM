using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //public Vector2 speed = new Vector2(50, 50);
    public float speed = 5f;

    public float movement = 5f;
    private Rigidbody2D rigidbodyComponent;
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Vertical");

        //movement = new Vector2(speed.x * inputX, 0);

        movement = inputX * speed;

        //jump = new Vector2(0, speed.y * inputY);
	}

    void FixedUpdate()
    {
        if (rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }

        Vector2 velocity = rigidbodyComponent.velocity;
        velocity.x = movement;
        rigidbodyComponent.velocity = velocity;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbodyComponent.velocity = new Vector2(rigidbodyComponent.velocity.x, 10);
    }
}
