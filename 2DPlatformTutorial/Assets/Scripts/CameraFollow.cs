using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float lastY = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.y = (player.position + offset).y;

        if (position.y - lastY > 0)
        {
            
            transform.position = position;
            //lastY = position.y;
        }

        
    }
}
