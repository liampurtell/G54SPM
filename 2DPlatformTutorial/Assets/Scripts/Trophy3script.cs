using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Trophy3script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Congratulations");
        //SceneManager.MoveGameObjectToScene(thePlayer.GameObject, sceneToLoad);
    }

}
