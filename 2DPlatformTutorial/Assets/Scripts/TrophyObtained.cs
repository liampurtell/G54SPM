using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyObtained : MonoBehaviour
{
    //public GameObject thePlayer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Level 2");
        //SceneManager.MoveGameObjectToScene(thePlayer.GameObject, sceneToLoad);
    }

}
