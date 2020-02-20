using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);

    //public Vector2 direction = new Vector2(-1, 0);

    public float rightLimit = 1f;
    public float leftLimit = 1f;

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
    private int direction = 1;
	
	// Update is called once per frame
	void Update () {
        

        if(transform.position.x > rightLimit)
        {
            direction = -1;
        }
        else if (transform.position.x < leftLimit)
        {
            direction = 1;
        }

        //movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
        movement = Vector3.right * direction * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        rigidbodyComponent.velocity = movement;
    }
}
